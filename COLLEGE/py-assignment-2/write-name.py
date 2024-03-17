no,ntw,nth=[str(x) for x in input("Please enter 3 names.\nex: Lilo, Stitch, Angel\n\nInput: ").strip().split(',')] # get the 3 names, realistically i can do this another way but i will put that in another script
nl = [no+"\n",ntw.lstrip()+"\n",nth.lstrip()] # strip whitespace to the left of second and third name, append newlines to first and second
with open("names.txt", "w") as nf: # using "with open" both saves a line of code and closes the file itself when it is done
    nf.writelines(nl)