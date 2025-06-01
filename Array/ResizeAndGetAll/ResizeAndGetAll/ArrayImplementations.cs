using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace ResizeAndGetAll
{
	public static class ArrayImplementations
	{
		public static void ResizeArray<T>(ref T[] sourceArray, int newSize)
		{
			// validations
			if (newSize <= 0) return;
			if (sourceArray == null) return;
			if (newSize <= sourceArray.Length) return;

			// resizing process
			T[] newArray = new T[newSize];

			Buffer.BlockCopy(sourceArray, 0, newArray, 0,
							Buffer.ByteLength(sourceArray));

			sourceArray = newArray;
		}

		public static T GetAt<T>(T[] Arr, int index, int sizeOf)
		{

			if (index < 0) return default(T);
            ref byte zeroAdrr = ref MemoryMarshal.GetArrayDataReference((Array)Arr);
            ref byte indexRef = ref Unsafe.Add(ref zeroAdrr, index * sizeOf);
            ref T item = ref Unsafe.As<byte, T>(ref indexRef);
			return item;

        }
	}
}