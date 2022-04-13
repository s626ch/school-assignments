customer_name = input('What is your name? ')
starting_balance = 5000.25
print(f'Hello {customer_name}! Your starting balance is ${str(starting_balance)}.')
pay_check = float(input('How much of your paycheck would you like to deposit? $'))
expenditure_item = input('What did you buy recently? ')
expenditure = float(input(f'How much did the {expenditure_item} cost? $'))
def checking_balance(user_name=customer_name, balance=starting_balance, deposits=pay_check, expense_item=expenditure_item, expense_amount=expenditure):
    ending_balance = balance + deposits - expense_amount
    print(f'Your current balance is: {ending_balance}')
checking_balance()