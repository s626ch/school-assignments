while True: # loop whole program
    while True: # loop asking for input, if NAN, ask again
        try:
            fnum = float(input("Please input the first number: "))
            snum = float(input("Please input the second number: "))
            break # exit loop if input valid
        except ValueError: print("Invalid input, please enter valid numbers.")
    operation = input("Please type what operation you would like to do:\nValid options: add, +, subtract, -, multiply, x, *, divide, /\n")
    match operation: # match/case for each operation, the ":g" trims trailing 0s
        case "add" | "+": print(f"{fnum+snum:g}")
        case "subtract" | "-": print(f"{fnum-snum:g}")
        case "multiply" | "x" | "*": print(f"{fnum*snum:g}")
        case "divide" | "/":
            if snum != 0: print(f"{fnum/snum:g}")
            else: print("You cannot divide by 0.")
    if input("Would you like to start again? Y/N: ").lower() in ["no", "n"]: break # ask to start again, exit if no
