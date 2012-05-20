

This project provide MonoTouch binding for the http://www.politepix.com/openears framework. 

There are two folders:
1) Binding - Contains binding code
2) OpenEarsTest - Sample project that shows how to use OpenEars.dll 

How to create binding 

1) Download the OpenEars distribution from http://www.politepix.com/openears
2) Unzip it 
3) Copy <unzip location>/OpenEarsDistribution/OpenEars/framework/OpenEars.framework/Versions/Current/OpenEars 
   file to the 'Binding' folder and rename it to libOpenEars.a
4) Go to the 'Binding' folder 
5) make clean
6) make all

This will generate the OpenEars.dll 

How to use:

1) Reference OpenEars.dll 
2) Add your languagemodel/dictionary file to your project 
3) Add your acoustic model to your project









