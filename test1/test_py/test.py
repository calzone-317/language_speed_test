import time

start = time.time()
total = sum(range(1, 100000001))
end = time.time()
print(f"Python: {end - start:.5f} sec")