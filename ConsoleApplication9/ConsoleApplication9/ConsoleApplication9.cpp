#include "stdafx.h"
#include <stdlib.h>
#include <stdio.h> 
#include <time.h> 
#include "iostream"
using namespace std;

	int main() {
		time_t start, end;

		time(&start);

		int a = 3;
		cout << "Hello world!!!!!!!!!!!!";

			time(&end);

		double seconds = difftime(end, start);

		printf("The time: %f seconds\n", seconds);
		system("pause");
	}


