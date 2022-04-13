
#* https://www.delftstack.com/howto/python/python-clear-console/
import os

def clearConsole():
    command = 'clear'
    if os.name in ('nt', 'dos'):  # If Machine is running on Windows, use cls
        command = 'cls'
    os.system(command)

#! clearConsole()

drawCharact = "----------" #! has to add 4 - each time 
spacingAmnt = "    " #? in relation to above, this is 4
pencilDrawing = f'''{drawCharact}
{spacingAmnt}      ^
{spacingAmnt}     /#\\
{spacingAmnt}    /###\\
{spacingAmnt}   /     \\
{spacingAmnt}  /       \\
{spacingAmnt} /~^~^~^~^~\\
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|    No*    |
{spacingAmnt}|           |
{spacingAmnt}|   ****    |
{spacingAmnt}|  **   **  |
{spacingAmnt}|      **   |
{spacingAmnt}|     **    |
{spacingAmnt}|    **     |
{spacingAmnt}|  *******  |
{spacingAmnt}|  *******  |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|           |
{spacingAmnt}|!!!!!!!!!!!|
{spacingAmnt}|!!!!!!!!!!!|
{spacingAmnt}@@@@@@@@@@@@@
{spacingAmnt}@@@@@@@@@@@@@
{spacingAmnt}@@@@@@@@@@@@@
{spacingAmnt} @@@@@@@@@@@ 
'''

while True:
    for x in range(6):
        print(pencilDrawing)
        #clearConsole()
        spacingAmnt += "    "
        drawCharact += "----"
    #drawCharact = "------"
    #spacingAmnt = "    "
    break