n = int(input())
fib_list = [0, 1]
f1 = 0
f2 = 1

for i in range(2, n):
    f3 = f1 + f2
    fib_list.append(f3)
    f1 = f2
    f2 = f3

# fib_string = ' '.join(str(fib_list))
print(*fib_list)