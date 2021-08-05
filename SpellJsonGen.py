# -*- coding: utf-8 -*-
"""
Created on Thu Aug  5 18:53:38 2021

@author: BorisTheBlade
"""

import json
data={}

try:# открывает и считывает значения
    with open('spells.json', 'r') as read_file:
        data = json.load(read_file)
        i = len(data)
    print(i)
except:# если нет такого файла то создаёт новый
    with open('spells.json', 'w') as create_f:
        json.dump(data,create_f)
        i=0
    print(i)
    
while True:
   spell_name = input('Spell name(0 для выхода):\n')
   if spell_name == '0':
       break;
   spell_url = input('Url:\n')
   data[i]=[spell_name,spell_url]
   i+=1
        
with open('spells.json', 'w+') as f:
   json.dump(data, f, indent = 4)
