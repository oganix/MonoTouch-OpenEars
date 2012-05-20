
There are two folder
1) Binding - Contains binding code 
2) OpenEarsTest - Sample project using binding

How to create binding: 

1) Download the OpenEars distribution from http://www.politepix.com/openears
2) Unzip it 
3) Copy <unzip location>/OpenEarsDistribution/OpenEars/framework/OpenEars.framework/Versions/Current/OpenEars 
   file to the 'binding' folder  and rename it to libOpenEars.a
4) Go to the 'binding' folder 
5) make clean
6) make all

This will generate the OpenEars.dll 

How to use:

1) Reference OpenEars.dll 
2) Add your languagemodel/dictionary file to your project 
3) Add acoustic model to your project

Example of this can be find the OpenEarTest folder.







