# ACES-Factory

A REST-influenced Python HTTP API that forms the backend logic of ACES assignment generation and management. Frontend services (or instructors leveraging the API) can upload new assignments to be made available to students, from which students may download prepared versions (watermarked and git-templated). 

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
factory_1    | Collecting pyodbc==4.0.30
factory_1    |   Downloading pyodbc-4.0.30.tar.gz (266 kB)
factory_1    | Building wheels for collected packages: pyodbc
factory_1    |   Building wheel for pyodbc (setup.py): started
factory_1    |   Building wheel for pyodbc (setup.py): finished with status 'done'
factory_1    |   Created wheel for pyodbc: filename=pyodbc-4.0.30-cp38-cp38-linux_x86_64.whl size=68322 sha256=44e85b148a385613e420944e4bd3dc74f81c6845e75883720d3433e8eea08ce4
factory_1    |   Stored in directory: /root/.cache/pip/wheels/0e/6c/b9/4349f7ee206f997dcde5675372aed185a788729278ad749953
factory_1    | Successfully built pyodbc
factory_1    | Installing collected packages: pyodbc
factory_1    | Successfully installed pyodbc-4.0.30
factory_1    | WARNING: You are using pip version 20.2.1; however, version 20.2.2 is available.
factory_1    | You should consider upgrading via the '/usr/local/bin/python -m pip install --upgrade pip' command.
factory_1    | INFO:root:Starting httpd...
factory_1    |
```

If the last line of output, `INFO:root:Starting httpd` is observed, then the Factory container has successfully booted!

### Running the Tests

Coming soon!

## Deployment

TODO

## Built With

TODO

## Authors

* **@loganrios** - Containerization, documentation, refactoring as REST API
* **@TannerL** - Watermarking code, zipping directories