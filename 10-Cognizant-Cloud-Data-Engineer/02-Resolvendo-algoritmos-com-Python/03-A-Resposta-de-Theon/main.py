def persons():
    n = int(input())
    x = input().split()
    for i in range(n):
        x[i] = int(x[i])
    lowest = min(x)
    result = x.index(lowest) + 1

    return result


print(persons())
