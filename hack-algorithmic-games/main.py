# number guessing game
# oh god i'm going to have to over comment this.
# import random for random number gen
import random

# function to pick a random number
def pickNmbr():
    # set number to global to access it below
    global currentNum
    # pick a number from 1 - 100
    currentNum = random.randrange(100)
    # return the number
    return currentNum

def nmbrgame():
    # set user score
    usrScore = 10
    # dummy var
    newGuess = True
    # function to ask if user wants to play again
    def playAgain():
        newGuessAsk = input("Would you like to play again? ")
        # turn response to lowercase if has capitals
        newGuessAsk = newGuessAsk.lower()
        # continue game if user says yes
        if newGuessAsk in ('y', 'ye', 'yes', 'yea', 'yeah', 'ya', 'yep'):
            print("")
            newGuess = True
            return newGuess
        #if user says no, stop the game
        else:
            print("Thanks for playing!")
            print("")
            newGuess = False
            exit()
    # infinite loop created with dummy var
    while newGuess == True:
        # pick a random number
        pickNmbr()
        print("I'm thinking of a number from 1 to 100,")
        # turn user input into int to compare to picked number
        usr_q = int(input("what is it? "))
        # if the guessed number equals the random number,
        if usr_q == currentNum:
            # congratulate user
            print(f"Congrats! You got it right, the number was {currentNum}!")
            # increase score
            usrScore = usrScore + 1
            # report back score
            print(f"Your score is {usrScore}.")
            # print blank line
            print("")
            # ask if user wants to play again
            playAgain()
        # if the guessed number was wrong,
        else:
            # tell user that they were wrong
            print(f"You got it wrong, sorry, the number was {currentNum}.")
            # decrease score
            usrScore = usrScore - 1
            # report back score
            print(f"Your score is {usrScore}.")
            # print blank line
            print("")
            # ask if user wants to play again
            playAgain()
nmbrgame()
