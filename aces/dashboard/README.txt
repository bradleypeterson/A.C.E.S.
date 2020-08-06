How to Run the ACES Dashboard:

Step 1: Install Necessary Software
 - Install Docker
 - Install Git
 - Install Visual Studio or Visual Studio Code

Step 2: Clone the Repository from GitHub
 - Clone the repo from GitHub

Step 3: Create Docker Containers
 - Navigate to ACES/aces
 - Start docker containers by running “docker-compose up -d”
 - To stop it run “docker-compose down”
 - Large changes require you to stop and then run again (up and down)
 - Larger changes require that you totally clean the images, volumes, etc. that Docker has created for this      project. To do so, run “docker system prune -a”

If you’re wishing to run the Dashboard (UI for instructors and students) continue through the following step.

Step 4: Restore NuGet Packages
 - From Visual Studio, right click on the project and select “Restore NuGet Packages”

Go ahead and run the project in debug mode.
