# Regions-vs-Partial-Sample
Sample project to show the benefits of partial classes versus regions

The basic idea is that if the responsibility of the class can't be split, I prefer to use partial classes.

It makes it easy to find each "group" of methods, it helps with git push because two developers can work in separate files and you can search easily with VS without ReSharper

![](1-region.PNG)
![](2-partial.PNG)
![](3-partial.PNG)