// This is the prototype watermarking program. This program works buy taking a 
// unique key hashing it then using that as the seed to generate the "random" 
// dashes and astricks watermarks thoughout the file.  
// The file is then read and whenever the find any special comment it test it
// against the unique keys hashed random comment. 

#include <iostream>
#include <fstream>
#include <string>
#include <unordered_map>

std::ifstream cfile;
std::ifstream hfile;

//tester this goes through the file and test the file's unique comments those begining with 
// "//**", "//UID" or "//--" and see's if they are correct.
void testFiles() {
	std::string line;
	int count = 0;
	while (std::getline(cfile, line)) {
		// If line of code starts with //**, that line is a watermark
		// Check if the watermark has been tampered with
		if (line.substr(0, 4) == "//**") {
			std::string code = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "*";
				else code += " ";
			}
			if (code == line.substr(line.size() - 64)) std::cout << "Pass" << std::endl;
			else std::cout << "Fail" << std::endl;
		}
		// Check if the student's unique identification has been tampered with
		else if (line.substr(0, 7) == "//UID: ") {
			std::string uid = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			srand(hash);
			for (int i = 0; i < 12; i++) {
				int val = rand() % 62;
				if (val > 36) uid += 'a' + val - 36;
				else if (val > 10) uid += 'A' + val - 10;
				else uid += '0' + val;
			}
			if (uid == line.substr(7)) std::cout << "Pass" << std::endl;
			else std::cout << "Fail" << std::endl;
		}
		// If line of code starts with //--, that line is a watermark
		// Check if the watermark has been tampered with
		else if (line.substr(0, 4) == "//--") {
			std::string code = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "\t";
				else code += " ";
			}
			if (code == line.substr(line.size() - 64)) std::cout << "Pass" << std::endl;
			else std::cout << "Fail" << std::endl;
		}
	}

	while (std::getline(hfile, line)) {
		// If line of code starts with //**, that line is a watermark
		// Check if the watermark has been tampered with
		if (line.substr(0, 4) == "//**") {
			std::string code = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "*";
				else code += " ";
			}
			if (code == line.substr(4)) std::cout << "Pass" << std::endl;
			else std::cout << "Fail" << std::endl;
		}
		// Check if the student's unique identification has been tampered with
		else if (line.substr(0, 7) == "//UID: ") {
			std::string uid = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			srand(hash);
			for (int i = 0; i < 12; i++) {
				int val = rand() % 62;
				if (val > 36) uid += 'a' + val - 36;
				else if (val > 10) uid += 'A' + val - 10;
				else uid += '0' + val;
			}
			if (uid == line.substr(7)) std::cout << "Pass" << std::endl;
			else std::cout << "Fail" << std::endl;
		}
		// If line of code starts with //--, that line is a watermark
		// Check if the watermark has been tampered with
		else if (line.substr(0, 4) == "//--") {
			std::string code = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "\t";
				else code += " ";
			}
			if (code == line.substr(line.size() - 64)) std::cout << "Pass" << std::endl;
			else std::cout << "Fail" << std::endl;
		}
	}
}


// this takes the raw file and for ever comment begining with "//**", "//UID" or "//--"
// adds a "Random" amount of * - or tabs based on the unique hashed key.
void makeFiles() {
	std::ofstream newFile;
	std::string line;
	int count = 0;

	newFile.open("JosephHwang_StacksAndQueues.cpp");
	while (std::getline(cfile, line)) {
		// If line of code starts with //**, that line is a watermark
		// Generate a unique pattern and add it to the document
		if (line == "//**") {
			std::string code = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "*";
				else code += " ";
			}
			newFile << "//**" << code << std::endl;
		}
		else if (line == "//Student:") {
			newFile << "//Student: " << "Joseph Hwang" << std::endl;
		}
		// Generate a unique identification for the student and add it to the document
		else if (line == "//UID:") {
			std::string uid = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			srand(hash);
			for (int i = 0; i < 12; i++) {
				int val = rand() % 62;
				if (val > 36) uid += 'a' + val - 36;
				else if (val > 10) uid += 'A' + val - 10;
				else uid += '0' + val;
			}
			newFile << "//UID: " << uid << std::endl;
		}
		// If line of code starts with //--, that line is a watermark
		// Generate a unique pattern and add it to the document
		else if (line.substr(0, 4) == "//--") {
			std::string code = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "\t";
				else code += " ";
			}
			newFile << line << code << std::endl;
		}
		else {
			newFile << line << std::endl;
		}
	}
	newFile.close();

	newFile.open("JosephHwang_StacksAndQueues.h");
	while (std::getline(hfile, line)) {
		// If line of code starts with //**, that line is a watermark
		// Generate a unique pattern and add it to the document
		if (line == "//**") {
			std::string code = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "*";
				else code += " ";
			}
			newFile << "//**" << code << std::endl;
		}
		else if (line == "//Student:") {
			newFile << "//Student: " << "Joseph Hwang" << std::endl;
		}
		// Generate a unique identification for the student and add it to the document
		else if (line == "//UID:") {
			std::string uid = "";
			// Generate a psudo random hash key for the student
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			srand(hash);
			for (int i = 0; i < 12; i++) {
				int val = rand() % 62;
				if (val > 36) uid += 'a' + val - 36;
				else if (val > 10) uid += 'A' + val - 10;
				else uid += '0' + val;
			}
			newFile << "//UID: " << uid << std::endl;
		}
		// If line of code starts with //--, that line is a watermark
		// Generate a unique pattern and add it to the document
		else if (line.substr(0, 4) == "//--") {
			std::string code = "";
			std::size_t hash = std::hash<std::string>{}("Joseph Hwang");
			count++;
			srand(hash + count);
			for (int i = 0; i < 64; i++) {
				int val = rand() % 2;
				if (val == 0) code += "\t";
				else code += " ";
			}
			newFile << line << code << std::endl;
		}
		else {
			newFile << line << std::endl;
		}
	}
	newFile.close();
}

//main file used to create/test if the file is watermarked
int main() {
	std::string cfileName;
	std::string hfileName;

	std::cout << " -----------------------------------------------------------------------------" << std::endl;
	std::cout << " Copyright 2020, Bradly Peterson, Weber State University, All rights reserved." << std::endl;
	std::cout << " -----------------------------------------------------------------------------" << std::endl;
	std::cout << std::endl;

	while (true) {
		std::cout << " cpp File: ";
		std::getline(std::cin, cfileName);
		cfileName.erase(0, 1);
		cfileName.erase(cfileName.size() - 1, 1);
		cfile.open(cfileName);
		if (!cfile.is_open()) std::cout << " File Not Found." << std::endl;
		else if (cfileName.substr(cfileName.size() - 3, 3) != "cpp") std::cout << " Invalid File Type." << std::endl;
		else break;
	}

	while (true) {
		std::cout << "   h File: ";
		std::getline(std::cin, hfileName);
		hfileName.erase(0, 1);
		hfileName.erase(hfileName.size() - 1, 1);
		hfile.open(hfileName);
		if (!cfile.is_open()) std::cout << " File Not Found." << std::endl;
		else if (hfileName.substr(hfileName.size() - 1, 1) != "h") std::cout << " Invalid File Type." << std::endl;
		else break;
	}

	// have to comment out the functions based on which one you wish to test.
	testFiles();
	//makeFiles();

	cfile.close();
	hfile.close();

	std::cout << std::endl << " Press Any Key To Continue...";
	std::cin.get();
}