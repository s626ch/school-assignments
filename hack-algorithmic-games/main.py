# number guessing game
import random

def pickNmbr():
    global currentNum
    currentNum = random.randrange(100)
    return currentNum

def nmbrgame():
    usrScore = 10
    newGuess = True
    def playAgain():
        newGuessAsk = input("Would you like to play again? ")
        newGuessAsk = newGuessAsk.lower()
        if newGuessAsk in ('y', 'ye', 'yes', 'yea', 'yeah', 'ya', 'yep'):
            print("")
            newGuess = True
            return newGuess
        else:
            print("Thanks for playing!")
            print("")
            newGuess = False
            exit()
    while newGuess == True:
        pickNmbr()
        print("I'm thinking of a number from 1 to 100,")
        usr_q = int(input("what is it? "))
        if usr_q == currentNum:
            print(f"Congrats! You got it right, the number was {currentNum}!")
            usrScore = usrScore + 1
            print(f"Your score is {usrScore}.")
            print("")
            playAgain()
        else:
            print(f"You got it wrong, sorry, the number was {currentNum}.")
            usrScore = usrScore - 1
            print(f"Your score is {usrScore}.")
            print("")
            playAgain()
nmbrgame()
