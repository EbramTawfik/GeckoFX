#include<stdlib.h>
size_t je_malloc_usable_size_in_advance(size_t n){ return n; }
void * moz_xrealloc(void *ptr, size_t size) { return realloc(ptr, size); }
void DummyFunction() {};
