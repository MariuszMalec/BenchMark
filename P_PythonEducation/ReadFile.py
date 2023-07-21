import os
import time
start_time = time.time()
#0.054

cwd = os.path.abspath(os.getcwd())

file = os.path.join(cwd,"P_PythonEducation","Source","B011382_33N.SPF")

if not os.path.isfile(file):
    print("No file => " + file)

try:
    with open(file) as f:
        #lines = f.readlines()
        #[print(line) for line in f.readlines()]
        contents = f.read()
        #print(contents)
except FileNotFoundError:
    print(file + " => File not found. Check the path variable and filename")
    exit()

print("--- %s seconds ---" % (time.time() - start_time))