cmake_minimum_required (VERSION 3.10)

project (TestExample CXX)

set (SOURCES
    src/Arithmetic.cpp
    src/Entry.cpp)

set (HEADERS
    include/Arithmetic.h)

add_library(TestExample SHARED ${SOURCES} ${HEADERS})
include_directories(include)
