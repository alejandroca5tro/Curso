var fibo = [0, 1],
    max = 100,
    ind = 1,
    next;
do {
    ind++;
    next = fibo[ind - 2] + fibo[ind - 1];
    if (next <= max) {
        console.log(next);
        fibo[ind] = next;
    }
} while (next < max);