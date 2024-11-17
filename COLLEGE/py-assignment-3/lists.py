itm = ['bread', 'butter', 'strawberries', 'cookies', 'donut', 'confetti', 'milk', 'tea', 'towel', 'sponge'];bskt = []
while True:
    b=0
    for a in itm:
        b+=1;print(f"{b}: {a}")
    inp = int(input('Select item numerically: '))
    inp-=1 if inp != 0 else print(*bskt, sep=", ") & exit()
    bskt.append(itm[inp])