#define _CRT_SECURE_NO_WARNINGS 
#include <stdio.h> 
#include <conio.h> 

int sumDividers(int i) {
	int sum = 1;
	for (int k = 2; k <= i; k++) {
		if (i % k == 0)
			sum += k;
	}
	return sum;
}

int sumDividersLarge(int i) {
	int sum = 1;
	for (int k = 2; k <= i; k+=1000) {
		if (i % k == 0)
			sum += k;
	}
	return sum;
}



void sumDividersFinal(int num) {
	int max = 1, value = 1;
	for (int i = num * 0.98; i <= num; i++) {
		int sum = 1;
		for (int j = 2; j <= i; j++) {
			if (i % j == 0)
				sum += j;
		}
		if (max < sum) {
			max = sum;
			value = i;
		}
	}
	printf("Number %d with sum of Dividers %d", value, max);
}



void number(int n) {
	int max = 1, num = 1;

	for (int i = n*0.96; i <= n; i++) {
		if (i % 2 == 0) {
			sumDividers(i);
			if (max < sumDividers(i)) {
				max = sumDividers(i);
				num = i;
			}
		}
	}
	
	sumDividersFinal(num);
	
}



void main() {
	number(100);
	_getch();

}






#define _CRT_SECURE_NO_WARNINGS 
#include <stdio.h> 
#include <conio.h> 

int sumDividers(int i) {
	int sum = 1;
	for (int k = 2; k <= i; k++) {
		if (i % k == 0)
			sum += k;
	}
	return sum;
}

int sumDividersLarge(int i) {	// Поиск для больших значений
	int sum = 1;
	for (int k = 2; k <= i/16; k+=1000) {
		if (i % k == 0)
			sum += k;
	}
	return sum;
}

int sumDividersSuper(int i) { 
	int sum = 1;
	for (int k = 2; k <= i / 100; k += 1000) {
		if (i % k == 0)
			sum += k;
	}
	return sum;
}

void sumDividersFinal(int num) {	// Уточняет поиск
	int max = 1, value = 1;
	for (int i = num * 0.998; i <= num; i++) {
		int sum = 1;
		if (i % 2 == 0) {
			for (int j = 2; j <= i; j++) {
				if (i % j == 0)
					sum += j;
			}
		}

		if (max < sum) {
			max = sum;
			value = i;
		}
	}
	printf("Number %d with sum of Dividers %d", value, max);
}



void number(int n) {
	int max = 1, num = 1;
	if (n < 50000) {
		for (int i = n*0.96; i <= n; i++) {
			if (i % 2 == 0) {
				sumDividers(i);
				if (max < sumDividers(i)) {
					max = sumDividers(i);
					num = i;
				}
			}
		}
	}
	if (n >= 50000 & n < 1000000) {
		for (int f = n*0.98; f <= n; f+=1) {
			if (f % 2 == 0) {
				sumDividersLarge(f);
				if (max < sumDividersLarge(f)) {
					max = sumDividersLarge(f);
					num = f;
				}
			}
		}
	}
	else {
		for (int h = n*0.98; h <= n; h += 1000) {
			if (h % 2 == 0) {
				sumDividersSuper(h);
				if (max < sumDividersSuper(h)) {
					max = sumDividersSuper(h);
					num = h;
				}
			}
		}
	}
	sumDividersFinal(num);
	
}



void main() {
	number(1000000);
	_getch();

}







#define _CRT_SECURE_NO_WARNINGS 
#include <stdio.h> 
#include <conio.h> 



void main() {
	int n = 1000000;
	int max = 1, num = 1;
//***************************************************************************************
	if (n <= 1000) {
		for (int i = n * 0.5; i <= n; i++) {
			int sum = 1;
			if (i % 2 == 0) {
				for (int j = 2; j <= i; j++) {
					if (i % j == 0)
						sum += j;
				}
			}
			if (max < sum) {
				max = sum;
				num = i;
			}
		}
	}
//****************************************************************************************
	if (n > 1000 && n <= 100000) {
		for (int l = n * 0.8; l <= n; l++) {
			int sum = 1;
			if (l % 12 == 0) {
				for (int k = 2; k <= l; k++) {
					if (l % k == 0)
						sum += k;
				}
			}
			if (max < sum) {
				max = sum;
				num = l;
			}
		}
	}
//****************************************************************************************
	if (n > 100000) {
		for (int i = n * 0.97; i <= n; i++) {
			int sum = 1;
			if (i % 120 == 0) {
				for (int j = 2; j <= i; j++) {
					if (i % j == 0)
						sum += j;
				}
			}
			if (max < sum) {
				max = sum;
				num = i;
			}
		}
	}
//****************************************************************************************
	printf("Number %d with sum of dividers %d", num, max);
	_getch();
}
