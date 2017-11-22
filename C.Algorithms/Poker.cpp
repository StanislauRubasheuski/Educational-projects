#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
enum combo { nothing, para, dvepari, troika, kare, Full, straight };


struct Card {
	int suit, num;
};
int deck[52];
void init() {	// Инициализация колоды. Установка начальных значений
	for (int i = 0; i < 52; i++)
		deck[i] = i;
}

void shuffle() {
	for (int i = 0; i < 52; i++) {
		int k = rand() % 52;
		int c = deck[k];
		deck[k] = deck[i];
		deck[i] = c;
	}
}

Card convertToCard(int n) {
	Card card;
	card.suit = n / 13;
	card.num = n % 13;
	return card;
}

void printCard(Card card) {
	switch (card.suit) {
	case 0: printf("Buba "); break;
	case 1: printf("Chirva "); break;
	case 2: printf("Kresti "); break;
	case 3: printf("Pika "); break;
	}
	switch (card.num) {
	case 0: printf("Ace\n"); break;
	case 10: printf("J\n"); break;
	case 11: printf("Q\n"); break;
	case 12: printf("K\n"); break;
	default: printf("%d\n", card.num + 1);

	}
}

int analise() {
	int value1 = 0, value2 = 0;
	const int c = 13;
	int hand[c] = { 0 };
	for (int i = 0; i < 5; i++)
		hand[deck[i] % 13] += 1;
	

	for (int i = 0; i < 13; i++) {
		if (hand[i] == 4)
			return 4;
		if (hand[i] == 3 || hand[i] == 2) {
			value1 = hand[i];
			for (int j = i + 1; j < 13; j++) {
				if (hand[j] == 2 || hand[j] == 3) {
					value2 = hand[j];
					break;
				}
				}
		}
		if (hand[i] == 1 && i < 9)
			if (hand[i + 1] == 1 && hand[i + 2] == 1 && hand[i + 3] == 1 && hand[i + 4] == 1)
				return 6;
	}

	if (value1 == 3 && value2 == 0)
		return 3;
	if ((value1 == 3 && value2 == 2) || (value1 == 2 && value2 == 3))
		return 5;

	if (value1 == 2 && value2 == 0)
		return 1;
	if (value1 == 2 && value2 == 2)
		return 2;
	if (value1 == 0 && value2 == 0)
		return 0;
}

void main() {
	srand(time(0));
	init();
	shuffle();
	for (int i = 0; i < 5; i++) {
		printCard(convertToCard(deck[i]));
	}
	int k = analise();
	printf("%d", combo(k));
	_getch();
}


#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
enum { nothing, para, dvepari, troika, kare, Full, straight };


struct Card {
	int suit, num;
};
int deck[52];
void init() {	// Инициализация колоды. Установка начальных значений
	for (int i = 0; i < 52; i++)
		deck[i] = i;
}

void shuffle() {
	for (int i = 0; i < 52; i++) {
		int k = rand() % 52;
		int c = deck[k];
		deck[k] = deck[i];
		deck[i] = c;
	}
}

Card convertToCard(int n) {
	Card card;
	card.suit = n / 13;
	card.num = n % 13;
	return card;
}

void printCard(Card card) {
	switch (card.suit) {
	case 0: printf("Buba "); break;
	case 1: printf("Chirva "); break;
	case 2: printf("Kresti "); break;
	case 3: printf("Pika "); break;
	}
	switch (card.num) {
	case 0: printf("Ace\n"); break;
	case 10: printf("J\n"); break;
	case 11: printf("Q\n"); break;
	case 12: printf("K\n"); break;
	default: printf("%d\n", card.num + 1);

	}
}

int analise() {
	int value1 = 0, value2 = 0;
	const int c = 13;
	int hand[c] = { 0 };
	for (int i = 0; i < 5; i++)
		hand[deck[i] % 13] += 1;
	

	for (int i = 0; i < 13; i++) {
		if (hand[i] == 4)
			return kare;
		if (hand[i] == 3 || hand[i] == 2) {
			value1 = hand[i];
			for (int j = i + 1; j < 13; j++) {
				if (hand[j] == 2 || hand[j] == 3) {
					value2 = hand[j];
					break;
				}
				}
		}
		if (hand[i] == 1 && i < 9)
			if (hand[i + 1] == 1 && hand[i + 2] == 1 && hand[i + 3] == 1 && hand[i + 4] == 1)
				return straight;
	}

	if (value1 == 3 && value2 == 0)
		return troika;
	if ((value1 == 3 && value2 == 2) || (value1 == 2 && value2 == 3))
		return Full;

	if (value1 == 2 && value2 == 0)
		return para;
	if (value1 == 2 && value2 == 2)
		return dvepari;
	if (value1 == 0 && value2 == 0)
		return nothing;
}

void main() {
	srand(time(0));
	init();
	shuffle();
	for (int i = 0; i < 5; i++) {
		printCard(convertToCard(deck[i]));
	}
	switch (analise()) {
	case 0: printf("Nothing!\n"); break;
	case 1: printf("Para!\n"); break;
	case 2: printf("DvePari!\n"); break;
	case 3: printf("Troika!\n"); break;
	case 4: printf("Kare!\n"); break;
	case 5: printf("Full House!\n"); break;
	case 6: printf("Straight!\n"); break;
	}
	_getch();
}





#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
enum { nothing, para, dvepari, troika, kare, Full, straight };


struct Card {
	int suit, num;
};
int deck[52];
void init() {	// Инициализация колоды. Установка начальных значений
	for (int i = 0; i < 52; i++)
		deck[i] = i;
}

void shuffle() {
	for (int i = 0; i < 52; i++) {
		int k = rand() % 52;
		int c = deck[k];
		deck[k] = deck[i];
		deck[i] = c;
	}
}

Card convertToCard(int n) {
	Card card;
	card.suit = n / 13;
	card.num = n % 13;
	return card;
}

void printCard(Card card) {
	switch (card.suit) {
	case 0: printf("Buba "); break;
	case 1: printf("Chirva "); break;
	case 2: printf("Kresti "); break;
	case 3: printf("Pika "); break;
	}
	switch (card.num) {
	case 0: printf("Ace\n"); break;
	case 10: printf("J\n"); break;
	case 11: printf("Q\n"); break;
	case 12: printf("K\n"); break;
	default: printf("%d\n", card.num + 1);

	}
}

int analise() {
	int value1 = 0, value2 = 0;
	const int c = 13;
	int hand[c] = { 0 };
	for (int i = 0; i < 5; i++)
		hand[deck[i] % 13] += 1;
	

	for (int i = 0; i < 13; i++) {
		if (hand[i] == 4)
			return kare;
		if (hand[i] == 3 || hand[i] == 2) {
			value1 = hand[i];
			for (int j = i + 1; j < 13; j++) {
				if (hand[j] == 2 || hand[j] == 3) {
					value2 = hand[j];
					break;
				}
				}
		}
		if (hand[i] == 1 && i < 9)
			if (hand[i + 1] == 1 && hand[i + 2] == 1 && hand[i + 3] == 1 && hand[i + 4] == 1)
				return straight;
	}

	if (value1 + value2 == 3)
		return troika;
	if (value1 + value2 == 5)
		return Full;

	if (value1 + value2 == 2)
		return para;
	if (value1 + value2 == 4)
		return dvepari;
	if (value1 + value2 == 0)
		return nothing;
}

void main() {
	srand(time(0));
	init();
	shuffle();
	for (int i = 0; i < 5; i++) {
		printCard(convertToCard(deck[i]));
	}
	switch (analise()) {
	case 0: printf("Nothing!\n"); break;
	case 1: printf("Para!\n"); break;
	case 2: printf("DvePari!\n"); break;
	case 3: printf("Troika!\n"); break;
	case 4: printf("Kare!\n"); break;
	case 5: printf("Full House!\n"); break;
	case 6: printf("Straight!\n"); break;
	}
	_getch();
}





#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
enum { nothing, para, dvepari, troika, kare, Full, straight };


struct Card {
	int suit, num;
};
int deck[52];
void init() {	// Инициализация колоды. Установка начальных значений
	for (int i = 0; i < 52; i++)
		deck[i] = i;
}

void shuffle() {
	for (int i = 0; i < 52; i++) {
		int k = rand() % 52;
		int c = deck[k];
		deck[k] = deck[i];
		deck[i] = c;
	}
}

Card convertToCard(int n) {
	Card card;
	card.suit = n / 13;
	card.num = n % 13;
	return card;
}

void printCard(Card card) {
	switch (card.suit) {
	case 0: printf("Buba "); break;
	case 1: printf("Chirva "); break;
	case 2: printf("Kresti "); break;
	case 3: printf("Pika "); break;
	}
	switch (card.num) {
	case 0: printf("Ace\n"); break;
	case 10: printf("J\n"); break;
	case 11: printf("Q\n"); break;
	case 12: printf("K\n"); break;
	default: printf("%d\n", card.num + 1);

	}
}

int analise() {
	int value1 = 0, value2 = 0;
	const int c = 13;
	int hand[c] = { 0 };
	for (int i = 0; i < 5; i++)
		hand[deck[i] % 13] += 1;


	for (int i = 0; i < 13; i++) {
		if (hand[i] == 4)
			return kare;
		if (hand[i] == 3 || hand[i] == 2) {
			value1 = hand[i];
			for (int j = i + 1; j < 13; j++) {
				if (hand[j] == 2 || hand[j] == 3) {
					value2 = hand[j];
					break;
				}
				break;
			}
		}
		if (hand[i] == 1 && i < 9)
			if (hand[i + 1] == 1 && hand[i + 2] == 1 && hand[i + 3] == 1 && hand[i + 4] == 1)
				return straight;
	}

	if (value1 + value2 == 3)
		return troika;
	if (value1 + value2 == 5)
		return Full;

	if (value1 + value2 == 2)
		return para;
	if (value1 + value2 == 4)
		return dvepari;
	if (value1 + value2 == 0)
		return nothing;
}

void main() {
	srand(time(0));
	init();
	shuffle();
	for (int i = 0; i < 5; i++) {
		printCard(convertToCard(deck[i]));
	}
	switch (analise()) {
	case 0: printf("Nothing!\n"); break;
	case 1: printf("Para!\n"); break;
	case 2: printf("DvePari!\n"); break;
	case 3: printf("Troika!\n"); break;
	case 4: printf("Kare!\n"); break;
	case 5: printf("Full House!\n"); break;
	case 6: printf("Straight!\n"); break;
	}
	_getch();
}



#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
enum { nothing, para, dvepari, troika, kare, Full, straight };


struct Card {
	int suit, num;
};
int deck[52];
void init() {	// Инициализация колоды. Установка начальных значений
	for (int i = 0; i < 52; i++)
		deck[i] = i;
}

void shuffle() {
	for (int i = 0; i < 52; i++) {
		int k = rand() % 52;
		int c = deck[k];
		deck[k] = deck[i];
		deck[i] = c;
	}
}

Card convertToCard(int n) {
	Card card;
	card.suit = n / 13;
	card.num = n % 13;
	return card;
}

void printCard(Card card) {
	switch (card.suit) {
	case 0: printf("Buba "); break;
	case 1: printf("Chirva "); break;
	case 2: printf("Kresti "); break;
	case 3: printf("Pika "); break;
	}
	switch (card.num) {
	case 0: printf("Ace\n"); break;
	case 10: printf("J\n"); break;
	case 11: printf("Q\n"); break;
	case 12: printf("K\n"); break;
	default: printf("%d\n", card.num + 1);

	}
}

int analise() {
	const int c = 13;
	int hand[c] = { 0 };
	for (int i = 0; i < 5; i++)
		hand[deck[i] % 13] += 1;
	int count = 0;

	for (int i = 0; i < 13; i++) {
		if (hand[i] == 4)
			return kare;
		if (hand[i] == 2)
			count += 2;
		if (hand[i] == 3)
			count += 3;
		
		if (hand[i] == 1 && i < 9)
			if (hand[i + 1] == 1 && hand[i + 2] == 1 && hand[i + 3] == 1 && hand[i + 4] == 1)
				return straight;
	}

	if (count == 3)
		return troika;
	if (count == 5)
		return Full;

	if (count == 2)
		return para;
	if (count == 4)
		return dvepari;
	if (count == 0)
		return nothing;
}

void main() {
	srand(time(0));
	init();
	shuffle();
	for (int i = 0; i < 5; i++) {
		printCard(convertToCard(deck[i]));
	}
	switch (analise()) {
	case 0: printf("Nothing!\n"); break;
	case 1: printf("Para!\n"); break;
	case 2: printf("DvePari!\n"); break;
	case 3: printf("Troika!\n"); break;
	case 4: printf("Kare!\n"); break;
	case 5: printf("Full House!\n"); break;
	case 6: printf("Straight!\n"); break;
	}
	_getch();
}
