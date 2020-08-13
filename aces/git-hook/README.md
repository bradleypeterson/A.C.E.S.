# Using hooks

This git hook currently gets the number of lines added, deleted, and the link to the commit.
If it is the first time the commit is made, it will also list their username, email, and what project it is.
It stores them in a text file currently called lineDiff.txt.
This can be utilized to also count the amount of watermarks are in the file for a given commit.
This should also be modified to send the data to the database to store the data for a given student.

## Adding hooks to a Git repository

As a prerequisite, make sure that Git is downloaded for your appropriate platform (Git for Windows, macOS, Linux). 

Clone the repository to which you wish to add the hooks.

```sh
git clone https://github.com/<username>/<my-repo>.git
```

After the repository has been cloned, navigate into `my-repo/.git` and run the following commands:

```sh
mv prepare-commit-msg.sample prepare-commit-msg
chmod +x prepare-commit-msg
```

After that you need to copy and paste what I have written for the hook in my file deleting what is already in there, and whenever the program is committed it will make a file (if it doesn’t exist) and list their username and email. And for every commit after as well as the first commit how many lines added and deleted, what datetime it was committed, and a url link for a given commit.
