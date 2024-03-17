nl = []
for i in range(1,4):
    name = input(f"Enter {i}{'st' if i == 1 else 'nd' if i == 2 else 'rd'} name: ") # ask for names, and have proper ordinals for extra swag level
    nl.append(name+"\n") # add name to list and append newline
with open("names.txt", "w") as nf: # using "with open" both saves a line of code and closes the file itself when it is done
    nf.writelines(nl)