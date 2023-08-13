# para_str = """A long para with several lines and escape characters such asTAB(\t).
#  The escape characters shall show up when displayed.
#  Even the new lines if given within the brackets [\n] shall also show up."""

# print (para_str)

# colors = ["orange","red","blue"]
# print (colors[0])
# print (colors[2])
# print (len(colors))

# values = [1,2,3,4,5,6]
# print (values[1:3])
# print (values[2:-1])
# print (values[:2])
# print (values[2:])
# print (values[::2])

# def changelist (mylist):
#     "This function append 5 to list"
#     mylist.append(5)
#     print ("values inside function", mylist)
#     return mylist
# mylist = [3,4,5]
# changelist(mylist)
# print("Values outside the function", mylist)


def sum_maker(number_list):
    "Finds and returns sum using list"
    list_sum = 0
    for num in number_list:
        list_sum += num
        return list_sum

print ("sum of [4,6,7] is: ", sum_maker([4,5,6]))