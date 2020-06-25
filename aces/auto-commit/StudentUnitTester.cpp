#include <cstdio>
#include <iostream>
#include <fstream>
#include <memory>
#include <stdexcept>
#include <string>
#include <array>

void commit();

int main()
{
	commit();

	//Student Unit Test go here vvvvvv 
	std::cout << "Hello World" << std::endl;
	exit(0);

}

void commit() {
	std::string str = "git commit -a -m auto_commit";
	const char* command = str.c_str();
	system(command);

#pragma region ClearCommand

	std::string cls;
#ifdef _WIN32
	cls = "cls";
#elif _WIN64
	cls = "cls"
#elif __APPLE__ || __MACH__
	cls = "clear";
#elif __linux__
	cls = "clear";
#elif __FreeBSD__
	cls = "clear";
#elif __unix || __unix__
	cls = "clear";
#else
	cls = "clear";
#endif

	const char* clrCommand = cls.c_str();
	system(clrCommand);
#pragma endregion



	std::ifstream myfile;
	myfile.open(".gitAssignment", std::ios::in);
	if (myfile.good())
	{
		int x;
		myfile >> x;

		if (x % 5 == 0) {

			std::cout.flush();
			str = "git remote update || echo Error";
			command = str.c_str();

			std::array<char, 128> psBuffer = {};
			std::array<char, 128> diverged = {};

#ifdef _WIN32
			FILE* pPipe = _popen(command, "r");
#elif _WIN64
			FILE* pPipe = _popen(command, "r");
#else
			FILE* pPipe = popen(command, "r");
#endif

			if (!pPipe)
				exit(1);

			int c = 0;
			while (fgets(psBuffer.data(), 128, pPipe) != NULL)
			{
				if (c == 1) {
					c++;
					for (int i = 0; i < 128; i++)
					{
						diverged[i] = psBuffer[i];
					}
				}
				else {
					c++;
				}
			}

			std::string update = diverged.data();
			update = update.substr(0, 5);
			std::cout << update << std::endl;




#ifdef _WIN32
			_pclose(pPipe);
#elif _WIN64
			_pclose(pPipe);
#else
			pclose(pPipe);
#endif
			if (update != "Error") {

				str = "git status";
				command = str.c_str();

				psBuffer = {};
				diverged = {};

#ifdef _WIN32
				pPipe = _popen(command, "r");
#elif _WIN64
				FILE* pPipe = _popen(command, "r");
#else
				FILE* pPipe = popen(command, "r");
#endif


				if (!pPipe)
					exit(1);

				c = 0;
				while (fgets(psBuffer.data(), 128, pPipe) != NULL)
				{
					if (c == 1) {
						c++;
						for (int i = 0; i < 128; i++)
						{
							diverged[i] = psBuffer[i];
						}
					}
					else {
						c++;
					}
				}

				std::string outOfDate = diverged.data();
				outOfDate = outOfDate.substr(12, 12);
#ifdef _WIN32
				_pclose(pPipe);
#elif _WIN64
				_pclose(pPipe);
#else
				pclose(pPipe);
#endif

				if (outOfDate != "is ahead of " && outOfDate != "is up to dat") {
					std::cout << "Your current repository is out of date."
						<< "\nPlease pull to update your repository." << std::endl;
					exit(0);
				}

			}
		}
		x++;
		myfile.close();
		std::fstream oFile;
		oFile.open(".gitAssignment", std::ios::in | std::ios::out | std::ios::binary);
		oFile << x << std::endl;
		oFile.close();


		system(clrCommand);



	}
	else {

		myfile.close();
		std::fstream oFile;
		oFile.open(".gitAssignment", std::ios::out);
		int y = 1;
		oFile << y << std::endl;
		oFile.close();
	}
}

