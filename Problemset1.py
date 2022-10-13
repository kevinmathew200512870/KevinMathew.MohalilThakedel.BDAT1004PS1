#!/usr/bin/env python
# coding: utf-8

# # PYTHON ASSIGNMENT : Problem Set 1

# Q 6 : Turning a word into pig-Latin

# In[3]:


def pig(s):
    a= s.lower()
    x=a[0]
    if(x in "aeiou"):
        return (a+"way")
    else:
        return (a[1:]+x+"ay")
print(pig("happy"))
print(pig("Enter"))
print(pig("kevin"))
print(pig("mathew"))


# #Q 7 : Records blood-types of patients and read the file with name and reports

# In[2]:


def bldcount(s):
    f = open(s)
    data = f.read()
    bloodtypes = data.strip().split(' ')
    valid_bloodtypes = ["A", "B", "AB", "O", "OO"]
    counts = [0,0,0,0,0]
    for bloodtype in bloodtypes:
        if bloodtype in valid_bloodtypes:
            idx = valid_bloodtypes.index(bloodtype)
            counts[idx] += 1
    for i, bloodtype in enumerate(valid_bloodtypes):
        print("There are", counts[i], "patients of bloodtype", bloodtype)
bldcount("bloodtype1.txt")


# Q 8 : Converts and returns the amount in US dollars.

# In[3]:


def curConv(curr, val):
    f = open("currencies.txt")
    lines = f.readlines()
    for line in lines:
        s = line.strip().split('\t')
        code = s[0]
        convFactor = float(s[1])
        name = s[2]
        
        if curr == code:
            return val * convFactor
    

print("Converted amount in USD:", curConv('EUR', 100))
print("Converted amount in USD:", curConv('JPY', 100))


# Q9: Error identify

# In[9]:


6 + ‘a’
a=[1,2,3,4,5,6,7,8,9,10,11]
print(a[12])
import math
math.sqrt(-1.0)
print(x)
# In[8]:
open('f.txt')


# Q 10 : Encryption

# In[7]:


def frequencies(s):
    letters= 'abcdefghijklmnopqrstuvwxyz'
    f=[0]*26
    for x in s :
        if x in letters:
            f[ord(x)-ord('a')]=f[ord(x)-ord('a')]+1
    return f
print(frequencies('The quick red fox got bored and went home.'))
print(frequencies('apple'))

