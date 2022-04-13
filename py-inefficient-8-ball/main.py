import random

def randomBall():
    numfart = int(random.uniform(1,10))
    if numfart == 1:
        print("Yes - definitely.")
    elif numfart == 2:
        print("It is decidedly so.")
    elif numfart == 3:
        print("Without a doubt.")
    elif numfart == 4:
        print("Reply hazy, try again.")
    elif numfart == 5:
        print("Ask again later.")
    elif numfart == 6:
        print("Better not tell you now.")
    elif numfart == 7:
        print("My sources say no.")
    elif numfart == 8:
        print("Outlook not so good.")
    elif numfart == 9:
        print("Very doubtful.")

def mainRoutine():
    newQuestion = True
    while newQuestion == True:
        usr_q = input("What would you like to ask the Magic 8-Ball?: ")
        if usr_q != "":
            randomBall()
            print("")
            newQuesAsk = input("Would you like to ask another question? ")
            newQuesAsk = newQuesAsk.lower()
            if newQuesAsk in ('y', 'ye', 'yes', 'yea', 'yeah', 'ya', 'yep'):
                print("")
                newQuestion = True
            else:
                print("Thank you, have a nice day. If you have any further questions, feel free to ask.")
                print("")
                newQuestion = False
        else:
            print("Please ask a question!")

mainRoutine()
