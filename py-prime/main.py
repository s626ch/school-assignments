try:
    n = int(input("\nPlease type a number, I'll tell you if it's prime: "))
except:
    print("I said type a number.\n")
    exit() 
def isp(v):
    if v == 2 or v == 3: return True
    if v < 2 or v%2 == 0: return False
    if v < 9: return True
    if v%3 == 0: return False
    r = int(v**0.5)
    f = 5
    while f <= r:
        print('\t',f)
        if v % f == 0: return False
        if v % (f+2) == 0: return False
        f += 6
    return True
if isp(n) == False:
    print(f"{n} is not prime.")
else:
    print(f"{n} is prime.")
d = {}
for nm in range(1,n+1):
    d["{0}".format(nm)] = int("{0}".format(nm))
l = list(d.values())
rs = list(filter(lambda x: (n % x == 0), l))
print(n,"can be divided by",rs,"\n")