// ConsoleApplication1.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"


#include <assert.h>

int main()
{
	int* it = nullptr;

	static_assert(sizeof(it) == 4,"1 == 2");

	//assert(nullptr != it);

    return 0;
}

