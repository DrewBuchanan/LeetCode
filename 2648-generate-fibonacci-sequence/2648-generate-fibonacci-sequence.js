/**
 * @return {Generator<number>}
 */
var fibGenerator = function*() {
    yield 0;
    yield 1;
    let one = 0;
    let two = 1;
    while (true) {
        let three = one + two;
        one = two;
        two = three;
        yield three;
    }
};

/**
 * const gen = fibGenerator();
 * gen.next().value; // 0
 * gen.next().value; // 1
 */