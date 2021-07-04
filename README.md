# Prim - Kruskal - Dijkstra
## What contains this repository?
This repository contains the code of a program of a university subject: Algorithmics.


In general, this software has functions to analyze images with a white background, these images contain circles of color black and different sizes, 
there are also some images with obstacles of different shapes, colors and sizes.
If you take a look at the tag project you will see there are four tags, I will describe each of them.

## Tag #1 PSALGv1 - Linked List
This tag contains the code for the first stage. At this stage the software can open a window directory on your computer,
you must search for an image on your computer (in pSALG / bin you can find images to test) and run the image analysis, 
this generates a linked list of each found circle in the image, finally the program shows the representation of the data found, 
you can repeat the process as many times as you want.

## Tag #2 PSALGv2 - Graph
This tag contains the code for the second stage. At this stage the software can do the same as the previous stage, 
so in this stage the software has the ability to create a dynamic graph with the circles found in the previous analysis, 
on this occasion the software shows the representation in the image of the graph and the text.

## Tag #3 PSALGv3 - Prim and Kruskal
In this stage we take advantage of the analysis and the generation of the graph of the previous stage and we implement the algorithms of Prim and Kruskal 
for the creation of minimum spanning trees, the representation of each algorithm or of both at the same time is shown on the representation 
of the graph generated previously, in addition to showing the selected edges and the order in which they were selected as well as the number 
of minimum spanning trees created in the analysis.

## Tag #4 PSALGv4 - Dijkstra
In the last tag, the previous stage was modified, now the Dijkstra algorithm for minimum paths from a given vertex was implemented, 
in addition to the use of events on the representation of the graph that allows placing a particle on a vertex and clicking on another 
showing the animation of the particle from source vertex to destination vertex by the minimum path found with the Dijkstra algorithm.

## Notes
The software was developed in C# using the SharpDevelop IDE, you can use any other IDE of your choice. Use the pSALG.sln file.

In the pSALG / bin folder you can find the used test images, avoid the images named as "prueba#.png".

The current code in the repository corresponds to that of label 4 "Dijkstra", if you want to obtain any code from a stage other than four, download the corresponding tag
