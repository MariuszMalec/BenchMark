import time
start_time = time.time()
#0.054
with open('/home/mario/repo/P_PythonEducation/Source/B011382_33N.SPF') as f:
    #lines = f.readlines()
    #[print(line) for line in f.readlines()]
    contents = f.read()
    print(contents)

print("--- %s seconds ---" % (time.time() - start_time))