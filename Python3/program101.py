# IntPrompt() function
def IntPrompt( text ):
    goodParse = False
    while not goodParse:
        try:
            result = int(input(text))
            goodParse = True
        except:
            print('*Invalid input. Try again*')
    return result

# Main script
count = IntPrompt('How many grades will you enter: ')
while count < 3:
    print('*Minimum value of 3 expected*')
    count = IntPrompt('How many grades will you enter: ')

print()
grades = []

# input grades
for i in range(count):
    grades.append(IntPrompt('Enter grade %d: ' %(i+1)))

# print grades
print('\nYour grades:')
found = False
for g in grades:
    if g == min(grades) and not found:
        print('%d *dropped*' %(g))
        found = True
    else:
        print('%d' %(g))

# print average
print('\nAverage of grades is %.2f' %((sum(grades)-min(grades))/(len(grades)-1)))
        


