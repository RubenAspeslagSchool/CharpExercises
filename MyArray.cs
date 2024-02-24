using System;

public class MyArray<T>
{
	private T[] array;
	
	public MyArray(int size) 
	{
		MyArray<int> myArray = new MyArray<int>(5);
		MyArray<string> str = new MyArray<string>(5);
	}
}
