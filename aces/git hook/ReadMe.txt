This git hook currently gets the number of lines added, deleted, and the link to the commit.
If it is the first time the commit is made, it will also list their username, email, and what editor is used.
It stores them in a text file currently called lineDiff.txt.
This can be utilized to also count the amount of watermarks are in the file for a given commit. I have currently started working on this.
This should also be modified to send the data to the database to store the data for a given student.
