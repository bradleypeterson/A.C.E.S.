#!/usr/bin/env python3
import argparse, os, re, random, string, json, zipfile
from hashlib import sha256

def zipdirectory(dir: str) -> str:
    filepaths: list = list()
    for root, _, files in os.walk(dir):
        for filename in files:
            filepaths.append(os.path.join(root, filename))

    zipdirlocation = "out.zip"
    zipped_dir = zipfile.ZipFile(zipdirlocation, 'w')
    for filename in filepaths:
        zipped_dir.write(filename)

    zipped_dir.close()
    return zipdirlocation


def watermark_file(path: str) -> int:
    print("-> Searching " + path + " for watermarkable lines...", end="")
    wf = open(path, "r")
    oldlines: list = wf.readlines()
    wf.close()
    newlines: list = list()
    lineno: int = 0
    watermarks: int = 0

    for line in oldlines:
        lineno += 1
        new = line
        if "aw:watermark" in line:
            print("ln" + str(lineno) + "...", end="")
            watermarks += 1
            new = line.replace("aw:watermark", "aw:" + watermark)
        newlines.append(new)

    if watermarks == 0:
        print("no watermarks found.")
    else:
        print("done.")

    wf = open(path, "w")

    for line in newlines:
        wf.write(line)

    wf.close()

    return watermarks

def generate_filelist(config: dict, directory: str) -> list:
    filelist: list() = list()
    m = config.get('method')
    if m == 'extension':
        pass
    elif m == 'namedfiles':
        for f in config.get('namedfiles'):
            filelist.append(f)
    return filelist

def en(s: str) -> bytes:
    return s.encode('utf-8')

def generate_watermark(email: str, asn_no: str):
    salt = ''.join(random.choice(string.ascii_lowercase) \
        for i in range(5))
    return sha256(en(asn_no) + en(email) + en(salt)).hexdigest()

def factory_create(directory: str, email: str, asn_no: str) -> str:
    # Check validity of each parameter.
    # if not os.path.isdir(directory):
    #     print("Error: directory does not exist.")
    #     return ''
    
    # if not os.path.exists(directory + "/.acesconfig.json"):
    #     print("Error: directory does not contain a .acesconfig.json file.")
    #     return ''

    email_regex = re.compile(r"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)")
    if not email_regex.match(email):
        print("Error: email argument is not an email address.")
        return ''

    if not len(asn_no) > 2:
        print("Error: asn_no must be greater than two characters.")
        return ''

    print("Preparing " + directory + " for " + email + " as " + asn_no)

    # Generate unique watermark code
    global watermark
    watermark = generate_watermark(email, asn_no)
    print("Generated watermark: " + watermark)

    # Open directory's .acesconfig.json file
    fconfig = open(directory + "/.acesconfig.json", "r")
    config: dict = json.loads(fconfig.read())
    fconfig.close()

    # Use config file to get list of markable files.
    markable_files: list = generate_filelist(config, directory)
    print("Method: " + config.get('method') + ", searching " + \
        str(len(markable_files)) + " file(s) for watermarkables.")

    total_marks: int = 0

    for f in markable_files:
        if os.path.exists(directory + "/" + f):
            total_marks += watermark_file(directory + "/" + f)

    print("Total watermarks generated: " + str(total_marks))

    zipdir: str = zipdirectory(directory)

    print("Created zipped folder at " + zipdir)

    return zipdir

# Note that main() should only be called if testing this module
# individually. The actual main point of entry is factory_create(),
# as called by another module.
def main():
    parser = argparse.ArgumentParser(description="Watermark files specified in " + \
        "an .acesfile and zip the folder.")
    parser.add_argument("directory", type=str, help="directory with a .acesfile")
    parser.add_argument("email", type=str, help="student email for watermarking")
    parser.add_argument("asn_no", type=str, help="assignment identifier (i.e. Asn1)")
    args = parser.parse_args()

    factory_create(args.directory, args.email, args.asn_no)
    pass

if __name__ == "__main__":
    main()