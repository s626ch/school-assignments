import random
w = {} # 25
for wl in range (1,26):
    w["string{0}".format(wl)] = str(input("Word {0}: ".format(wl)))
l = [f"Come {w['string1']} at WALMART, where you'll recieve {w['string2']} discounts on all of your favorite brand name {w['string3']}. Our {w['string4']} and {w['string5']} associates are there to {w['string6']} you {w['string7']} hours a day. Here you will find {w['string8']} prices on the {w['string9']} you need. {w['string10']} for the moms, {w['string11']} for the kids and all the latest electronics for the {w['string12']}. So come on down to your {w['string13']} {w['string14']} WALMART where the {w['string15']} come first.\n\n", f"\n\nBob was a {w['string2']} {w['string16']} who never really got his head out of the {w['string18']} and was always getting into {w['string20']} with the {w['string3']}. His favorite thing to do was {w['string1']} the {w['string23']} off of his sister's {w['string21']}. One day when he felt particularly {w['string4']}, he decided to {w['string24']} everyone he knew. Well, as you can guess, that didn't sit too well with {w['string25']}, and so {w['string25']} sent Bob to the one place he belonged...the town {w['string22']}. He still, to this day, sits there wondering why he got in trouble.\n\n", f"\n\nCompare our {w['string16']} Toasty O's to Honey {w['string16']} {w['string17']} cereal. You'll {w['string1']} the taste - and you'll {w['string1']} the price.\n{w['string18']}-O-Meal {w['string19']} cereals are not only {w['string2']}, they're the best {w['string20']} in the cereal isle. Compare {w['string18']}-O-Meal cereals with the {w['string5']} box brands, and you'll see they contain all of the same {w['string3']} and {w['string9']}. We use only high quality {w['string10']}, too, so you can {w['string6']} on the {w['string4']} {w['string21']} and {w['string8']} {w['string22']} in every {w['string19']}.\nMake the {w['string13']} choice with {w['string18']}-O-Meal cereals. for {w['string4']} {w['string21']}, {w['string8']} {w['string22']} and a {w['string14']} price, it's in the {w['string19']}!\n\n"] # 172 - walmart, 126 - never know, 055 - honey
print(random.choice(l))