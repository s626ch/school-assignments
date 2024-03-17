with open("names.txt", "r") as nf: # open file and then read each line
    nl = nf.readlines()
    for i, nm in enumerate(nl): # iterate through each name and also funny ordinals
        i += 1
        print(f"{i}{'st' if i == 1 else 'nd' if i == 2 else 'rd'} name: {nm}")