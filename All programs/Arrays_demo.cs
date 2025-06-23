//////// Arrays are collection of similar types of datas in contiguous memory locations
////////index, value ---0,1.....
//////// types : single dimensional, multi dimensional , double dimensional , 
//////// jagged arrays 


//////using System;


//////namespace ConsoleApp_Hexaware
//////{
//////     class Arrays_demo
//////    {
//////        static void Main(string[] args)
//////        {
//////            //int a = 10;
//////            //Int32 b = 0;

//////            //Console.WriteLine(a);
//////            //Console.WriteLine(b);


//////            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };  //Ist way
//////            //int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };//2nd way

//////            //int[] arr2 = new int[5];
//////            //arr2[0] = 1;
//////            //arr2[1] = 2;
//////            //arr2[2] = 3;
//////            //arr2[3] = 4;
//////            //arr2[4] = 5;

//////            //foreach (var i in arr2)
//////            //{
//////            //    Console.WriteLine(i);
//////            //}
//////            //=====================================================================
//////            //Console.WriteLine("Enter the size of single dimensional array: ");
//////            //int size=int.Parse(Console.ReadLine());

//////            //int[] arr5 = new int[size];

//////            //Console.WriteLine("Enter the array elements : ");
//////            //for (int i = 0; i < arr5.Length; i++)
//////            //{
//////            //    arr5[i]=int.Parse(Console.ReadLine());
//////            //}

//////            //Console.WriteLine("Array elements are : ");
//////            //for (int i = 0; i < arr5.Length; i++)
//////            //{
//////            //    Console.WriteLine(arr5[i]);
//////            //}

//////            // Console.WriteLine(arr);

//////            //Console.WriteLine("Array elements are : ");
//////            //for (int i = 0; i < arr.Length; i++)
//////            //{
//////            //    Console.WriteLine(arr[i]);
//////            //}
//////            //====================================================================================




//////            Console.ReadLine();
//////        }

//////    }
//////}


////// double , multi dimensional array demo

////using System;

////class matrixdemo
////{
////    static void Main(string[] args)
////    {
////        //int[,] arr1 = new int[2, 2];
////        ////     0      1
////        ////  0  0,0    0,1
////        ////  1  1,0    1,1
////        //arr1[0, 0] = 10;
////        //arr1[0, 1] = 12;

////        //arr1[1, 0] = 13;
////        //arr1[1, 1] = 14;


////        //Console.WriteLine("double dimensional array : ");
////        //for (int i = 0; i < 2; i++)
////        //{
////        //    for (int j = 0; j < 2; j++)
////        //    {
////        //        Console.WriteLine(arr1[i,j]);
////        //    }
////        //}

////        // accept row and column size from user and print in matrix format 


////        Console.WriteLine("Enter row size : ");
////        int rowsize=int.Parse(Console.ReadLine());

////        Console.WriteLine("Enter the column size : ");
////        int colsize=int.Parse(Console.ReadLine());

////        int[,] matrix = new int[rowsize,colsize];

////        Console.WriteLine("Enter array elements : ");
////        for (int i = 0; i < rowsize; i++)
////        {
////            for (int j = 0; j < colsize; j++)
////            {
////                matrix[i,j]=int.Parse(Console.ReadLine());
////            }
////        }
////        //    10    11
////        //    12    13 
////        Console.WriteLine("Matrix is : ");
////        for (int i = 0; i < rowsize; i++)  //i=0            i=1
////        {
////            for (int j = 0; j < colsize; j++)// j=0   j=1   j=0  j=1
////            {
////                Console.Write(matrix[i,j]+"\t");
////            }
////            Console.WriteLine();
////        }


////        Console.ReadLine();
////    }
////}


//// jagged arrays
//// array inside an array
//// all the array elements are single dimensional array
//// {      0
////      0 1 2 3
//// 0   {1,2,3},
//// 1   {1,2},
//// 2   {1,2,3,4}
//// }


//using System;

//class jaggedarraydemo
//{
//    static void Main(string[] args)
//    {

//        // WAP to accept the array size as input and 
//        // store them in jagged array and display them. 

//        int[][] jaggedarray = new int[3][];

//        jaggedarray[0]=new int[3] {2,3,4};
//        jaggedarray[1] = new int[2] { 2, 3 };
//        jaggedarray[2] = new int[5] { 2, 3, 4,5,6 };

//        Console.WriteLine("Jagged array elements are : ");
//        for (int i = 0; i < jaggedarray.Length; i++)
//        {
//            foreach (int j in jaggedarray[i])
//            {
//                Console.Write(j+"  ");

//            }
//            Console.WriteLine();
//        }
//        Console.ReadLine();
//    }
//}

//=============================================================