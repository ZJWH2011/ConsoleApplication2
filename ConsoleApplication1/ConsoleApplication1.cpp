// ConsoleApplication1.cpp : 定义控制台应用程序的入口点。
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

