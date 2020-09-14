# Helpers

This repo contains some of the most useful methods that I use in almost every project.
After taking them from a project to another project for many times, I finally decided to put them in my github for future projects.

So after all, it is mostly a reference for myself, but I hope that it can also be usefull for you.


**StringHelpers.cs**

| Method Name        | Use case												  |
| ------------------ | ------------------------------------------------------ |
| ReduceLength       | Gives a substring and adds "..." at the end if needed  |
| WithEnglishDigits  | Converts Arabic digits to English  	            	  |
| WithPersianLetters | Converts Arabic letters to Persian	              	  |



**CsvHelpers.cs**

| Method Name        | Use case												  |
| ------------------ | ------------------------------------------------------ |
| ReadAsEnumerable   | Reads the contents of a csv file using **CsvHelper**   |

The ReadAsEnumerable method will return an IEnumerable<T> that will yield records. What this means is that only a single record is returned at a time as you iterate the records. That also means that only a small portion of the file is read into memory. Be careful though. If you do anything that executes a LINQ projection, such as calling .ToList(), the entire file will be read into memory. CsvReader is forward only, so if you want to run any LINQ queries against your data, you'll have to pull the whole file into memory. Just know that is what you're doing.


