
This project provides MonoTouch binding for the [OpenEars](http://www.politepix.com/openears/).

There are two folders:

1. Binding - Contains binding code
2. OpenEarsTest - Sample project that shows how to use OpenEars.dll 

How to create the binding:

1. Download the OpenEars distribution from [here](http://www.politepix.com/openears).
2. Unzip it 
3. Copy <unzip location>/OpenEarsDistribution/OpenEars/framework/OpenEars.framework/Versions/Current/OpenEars 
   file to the 'Binding' folder and rename it to libOpenEars.a
4. Go to the 'Binding' folder 
5. make clean
6. make all

=> This will generate the OpenEars.dll 

How to use is it with MonoTouch 

1. Reference OpenEars.dll in your project
2. Add your languagemodel/dictionary files to your project 
3. Add your acoustic model to your project











