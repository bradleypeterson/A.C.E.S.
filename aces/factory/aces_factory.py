#!/usr/bin/env python3

import argparse, os, re, random, string, zipfile
from hashlib import sha256

# Declare globals
directory: str = ""
email: str = ""
asn_no: str = ""
watermark_code: str = ""

def generate_watermark() -> str:
    letters = string.ascii_lowercase
    salt = ''.join(random.choice(letters) for i in range(5))
    bsalt = salt.encode('utf-8')
    basnno = asn_no.encode('utf-8')
    bemail = email.encode('utf-8')
    return sha256(basnno + bemail + bsalt).hexdigest()

def watermark_file(path: str):
    print("-> Searching " + path + " for watermarkable lines...", end="")
    wf = open(path, "r+")
    lineNo: int = 0
    watermarks: int = 0
    for line in wf:
        lineNo += 1
        if "aw:watermark" in line:
            print("ln" + str(lineNo) + "...", end="")
            watermarks += 1
            line.replace("aw:watermark", "aw:" + watermark_code)

    if watermarks == 0:
        print("no watermarks found.")
    else:
        print("done.")

    wf.close()

#mark the single file passed in
def markPassedFile(file, hashValue):
	Ofile = open(file, "rt") #open the file and read it into a string
	data = Ofile.read()
	Ofile.close() #close the file
	countMark = data.count('ACESWatermark') #count how many watermarks are going to get placed
	data = data.replace('ACESWatermark', watermark_code) #replace all places with watermark
	Ofile = open(file, "wt") #open file to write to
	Ofile.write(data)	#write to the file with watermarks now.
	Ofile.close()

    print("There were" + str(countMark) + "marks added")
	return countMark #pass back how many watermarks were added

#loop through the folder to find what files need to be watermarked
def markFromFolder(folder): # marks all files under a folder with the watermark.
	numMarks = 0
	#loop through folders to find the file
	for filename in os.listdir(folder):
		if filename.endswith(".cpp"):
			fileLocation = os.path.realpath(folder) + "\\" +filename
			numMarks += markPassedFile(fileLocation, watermark_code) # mark the file at the location with the watermark and save number of watermarks that were placed
			continue
		else:
			continue
	#return the total number of watermarks
    print("There were " + str(numMarks) + "marks added")
	return numMarks

    # Declare the function to return all file paths of the particular directory
def retrieve_file_paths(dirName):

  # setup file paths variable
  filePaths = []

  # Read all directory, subdirectories and file lists
  for root, directories, files in os.walk(dirName):
    for filename in files:
        # Create the full filepath by using os module.
        filePath = os.path.join(root, filename)
        filePaths.append(filePath)

  # return all paths
  return filePaths

# Declare the main function
def ZipFiles(Files):
# Assign the name of the directory to zip
  dir_name = Files

  # Call the function to retrieve all files and folders of the assigned directory
  filePaths = retrieve_file_paths(dir_name)

  # printing the list of all files to be zipped
  print('The following list of files will be zipped:')
  for fileName in filePaths:
    print(fileName)

  # writing files to a zipfile
  zip_file = zipfile.ZipFile(dir_name+'.zip', 'w')
  with zip_file:
    # writing each file one by one
    for file in filePaths:
      zip_file.write(file)

  print(dir_name+'.zip file is created successfully!')

def main():
    parser = argparse.ArgumentParser(description="Watermark files specified in " + \
        "an .acesfile and zip the folder.")
    parser.add_argument("directory", type=str, help="directory with a .acesfile")
    parser.add_argument("email", type=str, help="student email for watermarking")
    parser.add_argument("asn_no", type=str, help="assignment identifier (i.e. Asn1)")
    args = parser.parse_args()

    email_regex = re.compile("(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)")
    if not email_regex.match(args.email):
        print("Error: email argument is not an email address.")
        exit(1)

    directory = args.directory
    email = args.email
    asn_no = args.asn_no
    watermark_code = generate_watermark()

    print("Generated watermark: " + watermark_code)

    print("Watermarking " + directory + " with " + email + "...")

    if not os.path.isdir(args.directory): #not a directory run file
        markPassedFile(directory) #mark the single file
        print("Error: directory does not exist.")
        exit(1)

    if not os.path.exists(args.directory + "/.acesfile"): #doesn't have .aces run for folder.
        markFromFolder(directory)
        print("Error: no .acesfile found in directory.")
        exit(1)


    acesfile = open(directory + "/.acesfile", "r")
    for line in acesfile:
        line = str.rstrip(line)
        markablefile = directory + "/" + line
        if os.path.exists(markablefile):
            watermark_file(markablefile)
    acesfile.close()

    #zip the file
    zipfile(directory)
    pass

if __name__ == "__main__":
    main()