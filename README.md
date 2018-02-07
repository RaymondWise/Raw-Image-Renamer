# Raw-Image-Renamer

I like taking pictures of birds. Lots of pictures of birds. My camera counts 0001 to 9999 and then starts over. So, if I have over 10K photos in a single folder and haven't changed the prefix on the camera, there are duplicates.

I shoot in RAW (Nikon). I edit in LightRoom. When I edit the .NEF (RAW), a XMP (Sidecar) with metadata is created and saved alongside the raw file. These have the same filename so when the NEF is opened, the program knows which metadata file to load with it.

I created this to go through the files of a folder and read the metadata, appending the date to the filename ensuring that the raw file and the metadata file remain with matching names.. It evolved from there.

----------

With this you

 1. Pick the image folder
 2. Specify if you want to change the base filename (e.g. 'NEF_0345' to 'Bullfinch')
 3. Decide if you want to append the date or just number the files (e.g. 'Bullfinch_100' or 'Bullfinch_20180101'

There are variables that can be used if you shoot canon .CRW or, really, any other filetype. I don't discriminate, it's just .NEF because that's what I have.
