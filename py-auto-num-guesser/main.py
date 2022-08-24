import random
from itertools import count
rn = random.randrange(100)
gn = random.randrange(100)
n = {}
for ng in count(0):
    n["{0}".format(ng)] = gn
    if n["{0}".format(ng)] < rn:
        gn = random.randrange(gn, 100)
    if n["{0}".format(ng)] > rn:
        gn = random.randrange(0, gn)
    if n["{0}".format(ng)] == rn:
        print(f"\nThe number was {rn}\nIt took {'{0}'.format(ng)} guesses.\n\n{n}\n")
        break