def maingm(): # this super cool oneliner allows for a comma separated input, this is also the function for the menu
    fnum,snum,oper = [float(x) if i < 2 else x for i, x in enumerate(input("Welcome to the...super epic cool very good calculator.\nPlease enter two numbers, and an operation.\n\nValid options for operation are: add, +, subtract, -, multiply, x, *, divide, /\n\nAn example input would be '7, 3, add'\nInput: ").split(','))]
    match oper: # run each thing accordingly per input, case matching is doubled up to account for space--or lack thereof--in input
        case "add" | "+" | " add" | " +": add(fnum,snum)
        case "subtract" | "-" | " subtract" | " -": sub(fnum,snum)
        case "multiply" | "x" | "*" | " multiply" | " x" | " *": mult(fnum,snum)
        case "divide" | "/" | " divide" | " /": divd(fnum,snum)
def add(fn,sn): print(f"{fn+sn:g}")
def sub(fn,sn): print(f"{fn-sn:g}")
def mult(fn,sn): print(f"{fn*sn:g}")
def divd(fn,sn): print(f"{fn/sn:g}") if sn != 0 else print("You cannot divide by 0.")
maingm()