# ACES-Factory

A REST-influenced Python HTTP API that forms the backend logic of ACES assignment generation and management. Frontend services (or instructors leveraging the API) can upload new assignments to be made available to students, from which students may download prepared versions (watermarked and git-templated). 

Basic usage for this service is reviewed in [this video](https://www.youtube.com/watch?v=19Zmw9mQgRk).

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

At minimum, running ACES-Factory requires an installation of [Git](https://git-scm.com/) and [Docker](https://docs.docker.com/get-docker/) (and, by extension, Docker-Compose). While Docker-Compose should come with most default installations of Docker (especially on macOS or Windows), separately installing Docker-Compose on Linux may be required, and it is suggested that you follow a guide based on your distribution.

**Windows 10**: [Follow the instructions for setup on Docker's documentation.](https://docs.docker.com/docker-for-windows/install/) Make sure you have Windows 10 Professional or Enterprise, and that you are configured to run Linux containers, **not** Windows containers.

**macOS**: [Follow the instructions for setup on Docker's documentation.](https://docs.docker.com/docker-for-mac/install/) A Homebrew installation should also be relatively painless, if you prefer. Since ACES-Factory will be manipulating folders on-disk (local to the repository), Docker should have access to macOS's filesystem (which is off by default). The easiest way to fix this is to go to `System Preferences > Security & Privacy > Privacy tab > Full Disk Access` and check the box next to Docker.

**VirtualBox and/or Linux**: Development environments for all of ACES have been successfully configured on [Manjaro Linux](https://manjaro.org/) (which has a Desktop environment) and [Arch Linux](https://www.archlinux.org/) (which is just a terminal). If you have the space, a Manjaro Linux virtual machine is an easy way to keep dependencies isolated from your hardware. 

Once Manjaro is installed, the following commands should be enough to get you running:
```bash
sudo pacman -Syu docker docker-compose
sudo systemctl start docker.service
sudo systemctl enable docker.service
sudo usermod -aG docker $USER
reboot
```

### Installing

Make sure Docker is started and verify your installation by running the following in the terminal and receiving roughly the following output (note that version numbers may differ):
```
$ docker version
Client: Docker Engine - Community
 Version:           19.03.12
 [...]

Server: Docker Engine - Community
 Engine:
  Version:          19.03.12
 [...]
```

Then, clone the repository and `cd` into the appropriate folder.
```bash
git clone https://github.com/bradleypeterson/ACES.git aces && cd aces/aces
```

To boot the Factory container in isolation, use Docker-Compose and verify that similar output is received.  

```
$ docker-compose up factory
Creating network "aces_default" with the default driver
Creating aces_factory_1 ... done
Attaching to aces_factory_1
[...]
factory_1    | INFO:root:Starting httpd...
```

If the last line of output, `INFO:root:Starting httpd` is observed, then the Factory container has successfully booted!

### Local Development

For ease of development (and since we haven't quite yet figured out how to debug within a Docker container), you can develop on ACES-Factory with just a standard Python3 installation for your platform. 

The main entrypoint can be accessed from the `$PROJECT_ROOT/aces/factory` directory.

```bash
python3 ./factory_listener.py
```

**Note**: the command may differ between `python` or `python3`, depending on your platform. Either way, make sure the scripts are being run with Python 3.8.5 or newer.

### Running the Tests

Coming soon! Some refactoring will have to occur to make the code more testable.

## Deployment

The true beauty of containerized applications is that running in development and running in production is virtually the same! Eventually a true CI/CD pipeline can replace this process, but for now, deployment is pretty trivial. Make sure you have SSH access to a server that has Docker, Docker-Compose, and Git.

Clone the repository onto the server, `cd` into the correct folder, and run `docker-compose up -d`. 

```bash
git clone https://github.com/bradleypeterson/ACES.git aces
cd aces/aces
docker-compose up -d
```

Once everything is built, use `docker-compose ps` to observe all the running pieces of the application.

```
$ docker-compose ps
      Name                   Command              State              Ports
-------------------------------------------------------------------------------------
aces_dashboard_1   dotnet A.C.E.S.dll             Up      0.0.0.0:8080->80/tcp
aces_db_1          /opt/mssql/bin/sqlservr        Up      0.0.0.0:1433->1433/tcp
aces_factory_1     ash /app/entrypoint.sh         Up      0.0.0.0:8081->8080/tcp
aces_gitea_1       /usr/bin/entrypoint /bin/s     Up      0.0.0.0:222->22/tcp,
                   ...                                    0.0.0.0:3000->3000/tcp
```

To deploy the Factory service on its own, run the following command:

```bash
docker-compose up -d factory
```

...and feel free to make requests against `localhost:8081`. 

## Roadmap

**Major Features**
* [x] Use POST to create watermarked assignments
* [x] Use GET to download prepared ZIP file downloads
* [ ] Use POST to upload new assignments and specify configuration
* [ ] Develop unit tests for major use cases

For smaller enhancements, we currently have an open [issue](https://github.com/bradleypeterson/ACES/issues/7).

## Authors

* **@loganrios** - Containerization, documentation, refactoring as REST API
* **@TannerL** - Watermarking code, zipping directories
