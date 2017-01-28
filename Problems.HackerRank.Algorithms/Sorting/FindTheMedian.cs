﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Find the Median
    /// https://www.hackerrank.com/challenges/find-the-median
    /// </summary>
    public class FindTheMedian
    {
        public static void Main()
        {
            Console.ReadLine(); // ignore array size.
            //var split = Console.ReadLine().Split(' ');
            var split = "39 46 61 44 53 49 56 92 72 67 16 2 86 11 99 4 5 53 62 4 95 6 88 60 24 16 52 50 54 54 62 20 12 34 1 17 10 47 84 70 97 35 55 71 3 27 61 90 62 23 56 10 14 46 49 73 60 85 63 96 66 68 75 65 6 89 46 44 64 82 47 31 88 19 67 47 48 45 43 7 82 62 26 0 22 8 44 80 20 37 74 64 69 21 67 5 65 76 9 6 60 40 86 52 9 68 42 24 77 7 50 45 16 2 34 71 31 84 40 4 31 56 73 42 38 14 34 42 56 11 72 39 19 31 36 44 48 57 31 76 90 74 69 16 65 76 97 2 98 14 77 65 94 36 24 13 93 49 63 70 64 37 36 14 38 70 18 71 80 15 49 56 56 34 29 22 29 71 11 63 34 22 40 59 8 88 91 7 2 3 90 49 68 35 57 33 8 44 91 37 5 65 5 95 85 8 37 29 35 76 8 60 6 81 96 11 30 70 26 26 41 36 40 37 17 44 35 26 81 7 71 27 93 4 63 35 11 38 41 57 84 55 0 38 48 69 14 3 8 22 29 11 42 97 56 40 23 13 57 69 93 98 83 60 94 11 96 2 85 13 22 32 36 19 10 61 28 79 25 78 89 38 19 13 54 76 6 93 9 73 97 84 20 33 54 52 33 79 10 61 23 58 87 12 46 73 0 44 36 87 33 45 35 91 98 6 20 7 87 64 85 89 54 62 22 84 93 44 57 83 54 24 69 87 17 76 99 4 29 37 45 50 47 42 35 87 0 16 91 52 50 46 8 25 99 42 56 66 71 19 63 84 71 14 16 58 51 72 7 52 96 38 68 50 98 32 72 18 46 24 49 97 72 62 93 87 22 45 56 81 40 57 75 41 67 13 22 33 81 93 25 78 90 52 52 68 23 51 56 51 88 53 46 32 8 72 42 58 81 3 68 52 93 82 20 31 69 99 61 58 84 5 10 46 60 14 17 13 45 12 3 27 99 25 88 35 27 81 72 12 49 19 39 63 9 19 83 74 68 13 4 39 11 59 30 67 72 78 79 15 60 89 23 77 1 38 56 92 44 48 82 57 14 3 37 66 53 19 24 57 94 22 31 30 11 40 68 10 27 10 70 44 41 17 14 54 6 29 91 69 67 53 93 54 80 45 59 57 8 34 19 72 9 72 46 34 19 70 97 58 93 43 38 22 11 65 17 89 80 2 48 85 1 20 97 91 15 66 59 40 98 9 51 56 10 17 34 54 27 44 12 52 86 49 48 23 15 91 59 3 18 37 27 11 77 34 61 15 11 53 3 63 60 27 60 25 86 42 57 4 24 98 14 8 89 11 14 17 60 54 77 99 4 29 72 93 11 18 10 43 76 72 49 82 53 20 56 30 23 83 37 35 45 37 91 89 12 11 30 46 83 2 75 10 13 35 43 38 12 60 4 42 53 65 23 97 54 44 0 8 90 63 45 59 15 31 95 47 86 31 31 97 98 99 0 32 31 15 65 74 12 96 82 48 64 29 41 73 54 88 71 86 51 96 73 87 5 83 29 15 42 72 53 1 88 94 69 88 84 93 24 88 89 99 29 31 15 76 85 32 46 79 71 1 65 88 85 25 7 98 26 16 90 98 29 44 94 90 57 66 41 81 22 74 77 64 37 8 64 22 96 71 41 17 25 8 18 20 49 24 94 82 69 83 80 88 17 41 19 16 26 11 98 46 22 55 56 99 93 74 73 54 99 66 91 43 81 12 77 35 70 92 85 50 79 44 45 31 95 72 32 86 78 91 12 41 80 67 73 69 18 99 15 1 44 82 1 87 42 36 49 87 26 17 1 98 44 54 97 55 54 88 71 14 1 33 17 14 40 94 68 53 32 47 90 47 93 89 70 11 9 13 44 98 19 83 33 98 36 58 44 8 74 75 15 16 32 65 61 97 58 32 58 87 2 95 78 16 65 80 46 83 42 10 40 93 40 14 38 55 98 95 66 30 7 40 81 26 11 1 14 5 43 97 30 71 49 34 63 55 24 28 46 21 32 88 30 28 33 66 99 76 63 85 59 20 73 47 20 82 98 98 75 39 22 61 5 34 17 29 85 78 43 11 89 59 20 27 34 99 70 23 28 6 38 6 79 4 28 88 69 47 4 94 80 75 62 84 46 35 85 80 8 63 24 30 12 45 89 98 17 49 88 9 10 95 16 43 74 23 41 99 39 29 14 41 60 13 97 82 37 38 82 26 91 7 85 38 78 21 21 53 9 47 85 52 56 1 65 51 7 52 87 0 94 5 20 70 72 37 35 75 79 28 15 99 44 37 33 93 28 9 77 1 50 77 19 12 50 91 40 67 4 26 54 51 99 30 17 30 49 90 14 27 23 24 58 80 49 83 0 13 13 96 44 62 22 91 73 13 33 78 66 2 3 88 78 16 85 0 42 69 77 1 71 39 90 18 1 49 88 91 74 25 41 94 96 43 96 16 75 32 56 53 3 18 45 11 15 91 76 71 82 13 33 58 87 81 35 98 12 33 39 62 87 60 45 92 30 69 87 38 77 51 12 4 70 43 34 31 65 8 57 52 26 89 49 73 37 74 70 25 68 13 23 44 12 32 48 85 17 7 69 43 92 55 24 83 68 34 11 56 21 83 4 70 78 23 85 73 37 74 16 22 85 12 56 8 91 59 23 49 63 49 40 56 94 64 81 99 1 94 42 89 21 49 15 13 29 15 41 3 35 30 93 17 71 3 26 67 46 67 93 36 57 69 50 76 69 83 70 67 96 72 67 23 83 40 97 38 81 14 21 23 55 60 75 75 33 89 21 21 16 7 22 19 66 92 85 85 84 54 59 95 70 44 20 50 82 45 7 48 67 72 72 9 17 65 76 51 56 15 49 26 57 51 47 53 68 77 2 49 7 78 21 99 3 37 44 54 66 72 43 11 54 16 48 5 86 34 68 33 27 92 53 54 1 82 51 42 28 42 37 17 94 80 11 84 54 88 47 91 16 82 97 68 16 78 35 14 85 49 70 1 95 53 63 84 60 82 87 27 33 43 50 89 73 90 98 33 32 32 40 84 38 29 99 97 42 4 55 61 25 84 14 76 64 33 93 18 75 26 74 55 36 81 97 44 0 78 21 14 57 41 29 90 10 30 92 28 83 67 78 82 76 97 37 77 77 65 41 82 85 26 52 98 37 79 86 28 12 62 28 72 84 77 60 21 90 74 13 85 68 65 69 33 78 30 18 88 88 8 1 65 89 82 78 88 67 46 68 7 48 44 24 98 18 57 10 65 56 23 40 50 57 70 96 85 53 33 53 18 14 91 10 70 57 70 95 58 91 22 65 94 24 86 56 4 71 79 47 77 47 51 37 57 65 53 95 24 74 4 51 25 86 94 60 26 49 54 24 47 45 42 55 64 16 22 61 38 90 7 99 6 68 28 39 37 89 71 38 12 2 9 31 35 14 24 51 2 91 78 12 47 16 46 32 55 60 43 34 21 12 25 94 20 69 80 74 70 37 27 85 26 8 18 94 12 26 9 3 68 36 74 99 95 65 63 54 17 44 68 87 60 36 31 48 51 87 1 50 69 64 98 76 65 0 98 39 46 52 27 0 92 57 66 18 30 0 13 54 39 29 63 53 63 24 28 49 35 95 53 28 65 63 24 91 3 82 56 55 23 78 63 78 52 53 26 80 0 24 7 72 13 13 63 95 23 25 34 53 83 28 42 32 50 66 64 73 90 34 26 49 22 69 71 0 46 48 38 6 49 6 62 64 90 14 59 58 27 86 93 55 52 58 6 17 53 96 82 80 3 61 87 25 96 84 23 8 67 66 98 59 90 62 9 6 84 51 45 9 67 53 66 9 70 57 16 87 21 74 83 94 98 5 99 28 12 80 94 40 83 19 34 99 2 3 69 70 29 96 60 56 79 95 48 29 29 6 91 39 94 84 34 8 10 48 66 81 54 49 85 38 69 39 75 95 33 70 69 80 74 34 56 72 40 59 48 85 9 19 81 20 32 93 32 38 20 17 60 13 14 90 43 76 43 79 47 23 64 3 78 19 19 7 9 56 89 79 74 75 5 46 61 78 32 38 9 44 85 16 20 15 93 84 33 55 79 94 63 5 21 65 35 93 19 17 47 17 46 32 73 56 34 33 39 98 93 87 96 26 6 41 80 31 14 23 6 95 38 52 80 95 26 57 89 92 59 27 82 62 72 57 6 92 8 90 78 92 83 43 46 36 82 96 43 98 17 70 19 72 56 13 72 45 63 67 43 85 31 25 46 36 73 0 52 55 26 40 40 46 55 79 46 18 8 2 57 95 86 14 0 22 28 1 52 22 51 26 2 89 31 3 51 14 92 82 4 5 86 20 28 26 47 90 21 56 75 2 38 54 54 90 8 21 67 88 1 70 41 47 22 18 11 85 37 68 30 50 45 22 6 96 10 80 41 50 74 57 88 63 74 96 68 72 59 93 54 63 85 54 92 57 26 85 6 79 36 71 81 85 71 5 87 10 42 47 21 64 38 83 3 83 94 45 72 58 74 1 38 84 46 45 45 81 58 58 9 58 56 2 43 7 36 36 17 68 20 67 61 87 36 28 95 74 64 36 75 88 5 95 78 41 18 12 18 11 59 65 72 93 49 37 71 79 98 5 15 16 36 17 35 53 29 86 54 66 53 57 72 15 27 9 44 73 19 34 98 23 85 30 59 96 3 25 18 70 81 98 82 13 98 0 2 39 60 67 94 36 57 81 43 27 64 65 58 24 75 23 5 80 31 36 70 75 98 53 30 92 6 49 87 80 18 9 47 56 26 16 52 49 12 67 68 4 34 65 30 22 72 24 56 35 69 29 16 86 51 18 66 68 64 15 35 7 20 23 77 38 18 53 55 36 14 19 84 61 54 2 52 44 64 16 42 83 37 91 30 65 80 51 22 83 20 96 9 83 97 14 96 30 29 82 61 65 68 62 10 31 58 52 94 44 45 51 15 85 20 4 60 49 82 25 35 29 18 80 32 37 47 23 44 91 15 35 24 76 48 11 2 81 82 91 14 76 14 82 91 9 61 2 2 4 2 23 32 57 89 7 19 84 11 13 74 51 51 8 45 41 39 75 97 12 77 31 17 71 75 41 43 99 1 86 71 44 30 53 21 92 49 29 7 56 41 0 76 71 25 48 80 32 38 45 13 12 52 44 31 25 83 47 78 42 95 0 12 60 87 52 74 14 19 50 79 89 65 21 5 58 22 29 44 90 35 21 61 69 82 1 76 74 44 16 52 83 16 0 49 4 90 95 4 18 95 73 29 63 28 72 50 85 58 25 23 18 64 20 90 98 92 96 95 39 49 4 66 21 79 2 10 44 93 3 62 17 40 64 87 23 36 84 45 28 48 34 67 51 59 69 14 84 66 35 50 6 86 56 3 9 54 18 10 61 82 43 9 31 74 61 63 15 38 65 45 38 25 30 17 3 58 89 12 86 35 68 59 81 79 20 79 47 49 60 55 73 27 83 91 87 99 38 10 25 35 92 30 44 44 30 89 10 51 55 56 89 67 25 2 63 4 35 62 58 37 48 91 98 86 32 50 26 0 73 7 92 41 56 13 30 29 42 50 70 12 4 78 93 19 43 33 64 80 81 49 67 97 17 87 3 37 1 21 88 0 99 61 84 82 9 52 4 22 66 65 96 55 63 95 41 66 78 78 88 89 2 31 70 98 9 62 68 86 83 73 64 76 48 79 37 20 76 98 89 4 74 6 93 98 84 90 70 50 7 74 47 22 79 56 50 0 26 94 65 68 57 96 43 39 20 6 20 45 4 40 97 90 14 9 92 56 80 36 76 4 51 89 58 92 96 17 76 2 45 65 51 74 19 72 52 78 19 82 87 19 86 68 94 30 74 90 73 4 42 87 78 62 89 3 99 45 92 21 4 1 86 0 84 66 26 45 5 4 33 74 36 48 61 1 62 28 70 84 56 8 46 65 18 20 68 48 20 30 3 48 21 44 34 95 6 67 33 9 44 19 9 16 42 54 53 35 41 45 61 77 1 79 29 97 89 77 80 63 60 55 70 46 76 8 31 14 28 52 73 30 33 35 53 78 37 75 31 78 13 96 69 95 97 44 31 16 58 74 68 33 99 8 92 64 61 4 9 8 62 47 37 7 57 17 40 5 25 26 46 43 84 90 76 74 6 45 30 4 83 22 10 14 89 73 69 97 83 12 46 86 48 75 61 20 4 9 77 8 94 59 15 21 86 47 99 12 38 97 13 92 88 26 68 85 11 54 98 53 75 14 57 96 82 92 46 34 10 22 1 1 21 13 49 65 28 94 70 83 0 72 77 21 23 17 79 80 55 92 50 69 5 63 78 86 73 90 40 68 2 16 25 30 44 58 53 65 50 59 45 40 0 62 24 92 1 28 67 57 39 93 86 35 76 90 12 3 87 93 1 86 40 68 43 36 61 9 70 27 40 95 84 35 94 99 85 86 85 74 17 97 94 50 29 38 25 41 29 32 10 37 31 1 54 74 16 91 31 14 20 31 1 14 87 64 42 55 21 67 53 20 43 32 80 24 8 99 3 76 75 74 33 70 86 40 82 29 12 35 46 85 76 15 74 47 22 38 33 50 83 9 50 5 77 1 33 17 66 0 8 24 91 50 64 60 93 83 61 74 46 3 70 65 45 73 19 67 53 38 34 52 36 14 36 62 33 49 41 14 87 75 58 92 37 11 27 51 68 58 14 32 16 52 88 52 95 84 3 69 47 80 20 77 75 37 58 99 86 96 81 0 32 7 61 37 13 71 11 43 28 22 90 28 21 74 26 77 23 56 87 90 50 68 61 17 28 10 69 95 0 94 11 5 8 49 66 67 63 88 22 64 96 70 45 97 52 61 26 60 16 42 74 25 32 58 84 92 96 82 29 94 10 11 65 91 75 79 81 33 11 15 2 14 16 58 86 36 63 9 51 25 27 33 65 23 99 69 14 66 66 39 93 1 46 50 90 80 66 96 98 0 9 23 50 1 9 50 51 76 28 17 37 76 7 73 60 43 29 46 29 95 39 60 90 52 18 53 50 2 61 48 4 79 9 19 10 5 71 7 45 54 81 26 80 97 33 38 31 90 75 65 87 24 50 90 35 34 91 22 22 36 42 88 48 18 18 86 6 31 20 76 79 13 12 16 21 1 0 1 37 40 45 2 75 79 8 47 25 84 81 85 0 45 16 71 21 50 82 41 99 29 66 58 43 46 86 74 50 62 0 49 95 23 35 36 29 61 63 10 84 13 24 96 54 35 76 41 28 31 7 40 95 28 89 79 57 65 3 34 89 89 34 46 68 42 45 73 33 78 54 31 24 54 16 1 26 85 84 86 97 0 10 15 56 65 88 93 87 17 99 78 69 90 93 1 49 63 71 39 23 23 30 30 72 26 1 53 54 58 8 95 31 38 56 57 93 78 79 79 35 78 90 15 34 29 70 57 54 38 92 58 23 50 45 8 5 90 55 84 73 96 66 43 16 28 7 27 29 60 35 78 17 93 91 29 60 3 12 70 67 40 58 16 10 49 91 52 34 45 70 50 87 18 29 50 97 71 48 9 71 68 71 16 7 38 40 79 83 42 91 37 43 45 23 55 26 54 51 7 88 0 49 54 33 84 82 97 81 15 91 3 88 88 84 88 90 32 0 3 55 59 4 16 74 64 5 5 41 67 21 83 59 6 46 1 1 89 7 55 46 78 52 53 89 18 33 47 77 75 50 43 41 35 54 53 98 66 26 88 14 2 22 42 51 20 95 96 13 79 84 12 25 83 38 54 87 84 26 22 2 29 15 36 12 84 70 44 69 34 3 76 86 1 49 4 19 50 61 48 40 5 55 28 65 88 83 27 81 4 52 58 74 83 44 93 76 23 27 99 40 81 32 75 39 14 98 87 75 51 37 92 82 31 11 24 39 93 42 36 95 68 54 30 89 48 59 60 41 81 41 64 34 86 61 7 42 23 90 85 57 23 69 98 99 57 81 67 83 19 50 85 25 10 1 91 18 1 61 91 31 20 93 66 40 46 70 1 88 94 20 97 15 15 70 15 99 19 11 21 8 30 24 73 43 61 72 68 30 5 2 47 34 38 70 34 58 44 83 41 36 97 97 19 90 55 56 35 15 17 85 51 23 17 49 9 65 28 75 29 21 13 74 16 43 21 17 38 35 41 36 91 94 11 12 40 81 98 90 98 93 23 78 88 20 85 79 97 72 81 59 14 34 72 60 34 29 15 77 96 88 32 24 98 2 11 6 75 9 68 34 27 43 61 26 16 94 45 39 17 46 79 39 91 38 96 46 96 71 67 42 79 97 6 17 15 64 43 10 16 86 59 47 92 72 68 50 51 66 53 5 93 57 29 8 65 52 89 95 79 59 64 17 40 29 7 93 58 5 34 72 39 15 44 76 7 76 70 9 86 84 35 57 0 16 89 97 3 25 48 38 79 45 12 70 66 13 14 38 83 67 52 77 53 89 97 23 9 55 60 15 52 79 52 27 55 31 26 98 98 45 45 85 20 35 54 51 61 60 91 30 85 48 73 44 57 52 54 26 13 98 22 13 29 64 63 62 2 31 96 56 60 80 15 78 81 66 65 66 41 48 63 18 78 87 32 62 0 79 58 26 65 35 60 34 74 67 89 52 69 82 11 35 63 77 54 86 56 79 63 39 55 15 34 46 0 60 15 10 48 7 90 64 95 12 75 7 53 63 77 92 91 86 39 69 23 65 35 93 95 29 23 45 70 93 3 78 32 91 65 72 55 44 50 82 40 24 49 87 85 57 96 17 42 58 96 24 66 43 70 55 18 32 25 36 2 20 18 62 65 96 58 13 68 69 37 89 67 43 31 59 47 44 41 60 64 46 94 32 54 76 2 68 99 8 89 85 32 37 85 82 17 96 54 72 72 19 79 1 50 25 18 49 37 26 42 22 45 78 57 48 26 0 92 12 96 9 47 11 30 55 93 78 46 42 17 14 49 58 65 13 55 78 92 64 41 60 83 53 79 94 41 48 46 98 27 87 47 92 79 34 78 64 12 73 65 69 43 34 73 41 62 51 31 79 63 25 82 61 77 42 92 66 10 17 43 15 88 89 70 75 89 15 80 65 10 41 14 79 36 80 36 57 91 22 18 95 53 43 85 43 76 5 98 99 68 42 84 35 74 21 57 96 25 62 74 90 78 24 72 23 25 89 84 17 64 93 88 53 48 99 56 3 71 98 43 4 11 7 85 82 94 89 62 38 95 77 90 90 29 84 29 78 24 76 63 18 36 34 64 23 30 39 22 44 6 56 91 80 19 17 31 51 59 51 71 29 3 79 67 26 71 15 95 30 42 30 8 8 40 39 91 97 81 38 15 52 42 37 96 14 24 52 16 22 54 36 97 45 49 49 90 57 30 74 27 37 39 30 48 71 3 85 9 57 79 37 96 0 75 64 0 55 71 26 35 21 46 20 72 30 45 69 54 0 9 1 36 6 23 72 45 14 9 52 70 24 46 79 44 71 60 32 92 96 94 45 65 90 36 72 84 45 91 71 3 35 94 72 68 93 95 97 5 90 75 28 54 87 49 89 7 87 50 79 28 22 58 13 83 49 80 98 8 5 67 33 81 54 5 15 9 86 41 32 40 38 57 33 76 41 3 42 13 73 60 87 68 47 35 69 34 8 13 26 89 13 41 45 69 48 87 6 56 37 22 98 12 96 18 79 77 29 78 62 35 72 31 81 15 37 70 57 30 89 3 34 99 35 42 99 77 69 32 64 97 90 47 70 71 53 95 50 93 93 49 98 20 49 54 49 82 11 25 6 89 28 43 41 6 46 40 78 28 63 71 3 12 58 54 8 96 92 48 98 92 5 11 37 72 92 38 91 9 81 6 39 81 47 69 67 82 99 52 90 91 0 68 1 52 35 36 33 87 75 31 90 85 79 38 16 64 85 38 59 0 75 27 1 89 4 28 15 98 0 98 76 12 73 9 48 6 75 58 29 77 87 99 56 53 69 41 74 75 71 95 25 67 94 46 63 41 67 29 51 79 3 91 51 90 81 71 54 22 49 66 38 9 15 10 74 28 69 80 95 21 50 73 81 93 44 5 1 50 17 71 1 33 15 61 64 49 49 0 36 72 58 50 90 23 12 32 37 90 25 35 44 18 28 95 22 51 71 78 40 31 62 70 22 88 71 38 54 18 69 68 14 23 80 97 21 88 86 2 30 43 40 18 88 35 99 53 66 97 14 71 83 64 90 8 30 67 30 40 58 87 20 70 44 61 84 94 54 83 57 76 47 94 38 49 20 71 32 8 39 3 89 46 95 53 84 82 77 16 61 41 90 35 87 39 46 52 27 23 57 44 60 77 77 32 76 60 63 18 42 40 71 36 24 29 31 71 77 87 75 53 29 43 49 27 38 14 76 69 40 50 43 55 23 49 24 73 60 91 78 29 66 72 92 17 12 54 19 37 65 17 44 42 19 12 52 89 44 88 50 63 75 61 39 97 8 9 84 1 72 38 95 31 60 80 91 14 51 88 80 59 99 28 12 85 37 34 61 56 78 21 99 32 96 99 61 93 93 89 24 71 74 5 65 68 15 25 80 35 83 35 53 34 64 29 91 28 73 31 64 76 44 11 41 82 55 36 58 71 94 32 70 21 8 4 13 36 0 23 11 48 35 86 67 68 15 35 0 41 34 42 12 65 37 49 66 66 80 51 58 7 33 91 21 85 97 7 29 44 7 73 8 48 31 83 13 20 97 7 25 9 76 70 17 0 82 25 0 92 44 46 19 6 72 17 40 15 94 67 57 67 75 64 3 96 3 85 3 51 82 17 16 59 80 41 88 68 55 63 33 43 94 64 64 43 55 11 92 13 45 50 12 25 25 95 24 20 19 96 98 39 98 56 75 30 56 26 36 2 87 16 66 64 10 41 42 46 16 0 66 61 44 17 54 7 28 91 98 20 16 8 6 15 4 28 20 41 50 36 29 76 43 36 39 11 88 21 87 8 49 89 64 61 5 24 44 67 70 35 67 55 80 85 53 67 69 82 64 1 37 65 96 40 87 2 12 92 80 96 99 64 38 41 39 39 62 92 49 76 53 48 81 23 69 67 85 3 4 74 55 14 93 68 36 98 74 71 21 79 22 66 68 66 53 69 23 95 94 7 73 71 49 34 94 6 46 86 82 32 78 11 69 23 26 29 98 96 25 98 18 31 67 63 44 18 44 68 28 15 93 10 57 38 43 4 20 97 67 74 3 61 63 62 38 6 32 76 81 44 83 20 7 74 9 59 11 5 23 99 18 33 92 90 33 31 67 94 92 11 44 47 48 59 82 2 18 9 99 61 26 41 98 4 19 62 6 30 80 26 79 74 12 14 73 25 67 69 81 49 82 86 46 85 94 40 65 44 40 29 48 72 80 47 91 26 48 55 45 48 51 45 24 80 64 74 70 89 89 21 88 97 74 72 19 76 60 50 41 75 66 86 66 81 39 3 9 0 56 51 62 45 9 79 50 69 60 25 66 36 23 81 65 85 52 58 17 56 86 40 49 44 50 35 68 84 32 40 34 36 52 88 90 41 14 87 80 30 62 58 61 64 96 68 99 25 80 31 91 85 45 27 71 18 34 94 81 37 6 6 19 54 93 92 35 48 68 37 59 15 88 6 27 55 0 14 64 90 65 37 77 43 57 98 39 58 32 77 62 8 25 57 47 43 89 80 7 95 21 41 31 19 75 81 12 43 52 48 93 64 93 62 7 19 12 65 87 83 1 61 28 57 70 30 28 42 1 99 45 68 13 80 91 51 64 3 72 3 11 41 85 46 55 11 70 83 76 88 29 74 5 73 4 64 93 84 23 36 37 88 32 24 2 49 56 58 85 64 24 70 90 9 70 57 6 24 80 84 1 68 25 11 12 79 68 29 13 64 3 85 41 10 71 79 27 76 25 97 83 95 23 46 56 84 97 72 3 29 67 38 34 0 65 93 86 9 50 85 42 80 82 84 20 74 35 62 45 94 71 51 81 5 77 58 13 31 89 68 23 77 5 42 19 40 19 8 3 96 93 74 92 30 33 41 28 60 93 87 78 54 94 57 13 74 86 69 2 41 67 68 20 82 16 30 61 4 71 69 87 80 81 93 44 61 43 25 36 91 6 95 74 96 69 14 42 30 54 49 2 66 39 61 3 70 80 60 11 13 83 52 85 32 38 46 26 34 33 68 43 17 72 39 8 88 78 3 87 16 29 37 18 79 12 94 16 41 91 22 30 14 13 60 91 54 41 14 33 39 27 1 55 20 97 97 20 95 34 51 10 93 32 9 73 35 20 4 26 17 90 94 77 59 25 34 39 84 29 39 17 98 24 92 66 65 16 95 51 16 88 99 21 53 45 45 71 38 16 23 11 52 2 74 8 69 77 89 67 91 61 78 14 83 98 19 85 8 93 31 88 67 18 55 38 80 42 5 69 32 91 13 70 15 14 52 64 39 54 41 77 14 7 60 45 44 62 91 60 28 17 23 63 33 69 10 31 98 38 1 82 42 99 45 26 38 42 50 72 73 75 24 22 43 26 59 98 39 87 55 39 98 18 74 37 96 20 44 41 78 73 69 39 63 20 29 49 9 78 6 17 31 14 32 58 96 98 53 84 51 87 96 86 74 10 71 14 38 32 94 76 49 20 49 59 35 16 1 17 43 14 98 94 54 52 13 97 90 24 56 83 57 74 41 77 52 68 36 84 47 49 96 24 83 13 13 98 55 69 35 64 14 26 32 31 25 65 32 35 61 82 58 8 47 34 88 64 12 40 12 73 61 70 49 9 48 70 37 17 14 95 16 48 44 99 31 77 28 4 84 84 12 78 45 58 87 25 41 50 81 22 58 5 26 72 13 2 71 78 53 95 28 8 18 66 61 75 91 31 8 94 90 35 29 67 59 37 72 11 33 53 24 74 28 7 66 59 26 33 97 61 5 89 93 62 45 90 15 60 87 70 40 10 65 6 10 29 47 66 91 42 31 63 5 32 57 59 79 2 29 1 19 75 13 86 42 17 60 88 56 37 49 65 80 26 50 84 76 36 4 68 27 28 56 94 80 9 29 66 19 62 41 85 98 36 33 83 10 11 88 32 33 82 28 72 28 35 1 4 87 96 0 80 4 37 24 92 13 8 99 71 61 19 43 11 53 12 17 79 17 6 8 25 90 52 88 40 89 4 85 67 86 6 94 93 98 42 90 66 59 61 17 11 17 0 82 65 46 12 98 46 56 46 65 41 99 61 85 81 22 87 98 94 10 73 2 83 70 63 34 84 39 88 26 81 76 34 55 56 39 31 22 89 29 56 14 98 24 99 39 93 99 77 33 19 11 96 27 7 63 80 89 50 25 29 30 81 21 73 25 40 89 88 54 59 71 76 48 62 76 61 18 18 69 29 70 27 65 25 11 85 37 96 47 88 5 92 41 44 20 96 86 25 11 41 75 48 99 34 63 99 20 87 21 60 50 52 64 70 76 59 49 55 17 48 39 10 78 34 79 45 61 64 78 55 0 18 67 81 47 85 21 90 88 21 47 42 41 30 8 75 27 99 61 72 9 96 78 79 65 85 16 61 41 61 62 14 43 85 75 93 49 62 41 40 11 55 17 16 23 15 93 52 71 71 35 61 3 79 3 33 6 91 64 95 55 46 73 9 9 39 56 9 40 5 25 3 75 5 32 71 62 46 48 16 12 5 31 84 75 22 79 27 25 31 11 7 51 36 88 34 82 37 76 52 41 41 49 72 58 28 56 26 0 47 16 26 42 95 9 44 31 16 61 40 14 81 97 10 78 34 31 96 54 30 17 99 98 55 50 58 73 23 81 1 80 88 18 36 9 99 97 10 25 14 34 77 64 42 95 75 27 26 45 30 20 50 89 41 90 10 32 99 80 49 35 97 15 27 53 56 92 92 3 85 20 36 17 47 96 44 75 91 54 38 31 89 85 9 82 54 13 43 10 46 46 52 10 62 7 85 34 44 52 86 71 34 61 78 75 8 82 13 86 93 83 98 28 6 85 83 79 47 28 34 21 38 96 56 82 14 43 25 4 22 5 62 57 12 39 19 23 93 86 20 44 93 15 35 44 27 92 65 15 19 58 79 44 65 39 47 64 12 35 28 8 7 47 78 73 95 42 48 10 86 35 88 14 32 1 53 37 81 41 9 96 39 55 49 48 93 36 34 86 69 64 74 22 11 25 80 91 84 78 80 16 39 62 36 94 29 57 44 36 68 26 37 9 42 67 49 32 96 74 14 9 63 93 10 89 34 52 79 8 70 60 44 64 39 68 77 29 5 88 7 28 32 13 36 89 24 19 62 45 0 47 82 38 9 90 41 89 52 52 55 34 10 74 16 6 16 22 4 92 43 69 27 22 40 11 66 94 94 6 53 18 66 45 18 83 56 84 87 83 80 29 60 94 3 67 12 75 45 27 86 81 95 12 7 33 70 47 71 15 91 40 34 48 18 30 26 46 7 1 71 15 44 43 50 29 65 96 27 95 97 61 37 1 18 21 32 95 85 47 44 12 11 14 12 94 80 34 26 1 59 19 94 72 15 61 70 81 17 71 53 69 29 1 67 57 84 53 26 88 20 25 79 73 28 67 48 21 8 27 15 45 75 38 43 51 56 32 62 31 66 43 24 34 22 15 31 51 91 75 32 5 69 26 2 1 35 63 78 0 14 23 27 39 15 40 88 7 44 68 92 52 13 44 90 77 70 79 25 41 5 51 48 21 62 38 76 90 6 34 66 68 45 31 12 34 56 19 79 41 84 13 71 82 77 15 76 71 46 25 42 73 82 89 27 13 64 29 81 99 76 69 59 89 79 95 13 17 17 14 36 56 10 54 23 3 62 38 73 83 82 8 40 25 85 38 96 65 43 82 89 40 70 31 25 58 14 51 62 66 75 14 68 73 23 80 36 93 1 24 2 42 86 49 1 88 74 97 21 96 79 2 36 1 83 68 54 95 36 62 23 51 85 29 83 23 31 95 7 86 77 22 67 75 94 16 96 41 42 63 94 10 88 5 2 94 35 41 68 45 63 38 61 58 43 25 69 15 2 91 22 92 67 2 83 71 42 52 73 34 32 50 41 68 18 39 44 31 31 13 63 28 80 97 46 62 58 34 61 12 31 64 87 1 78 19 87 53 49 63 76 94 88 44 68 94 37 83 81 64 10 36 65 15 59 24 44 6 93 50 56 71 80 73 85 75 98 85 35 10 29 95 29 12 99 72 92 79 80 86 77 30 73 22 96 19 40 90 38 4 49 91 33 83 60 95 76 24 92 20 10 66 16 77 80 26 57 19 72 92 85 32 84 87 23 92 20 91 27 40 32 23 53 72 30 49 54 66 52 35 12 29 45 52 64 97 42 3 89 12 5 92 42 33 82 56 84 5 99 76 28 99 50 55 70 94 88 33 32 26 13 71 92 47 84 96 15 82 82 23 31 75 83 68 89 13 24 77 65 97 66 57 23 73 96 20 54 51 50 6 88 6 96 38 26 47 18 39 26 98 40 34 63 32 9 7 48 59 36 42 58 25 36 71 11 78 27 6 52 1 94 28 35 0 23 47 22 39 60 61 97 63 72 44 86 23 88 90 88 24 56 56 93 55 95 77 98 88 77 77 41 3 77 20 33 42 84 22 27 29 37 73 20 2 62 61 0 97 60 84 5 40 99 25 68 2 4 16 54 13 56 84 43 22 74 10 42 69 2 86 5 97 35 83 99 10 50 69 59 2 8 10 83 75 1 18 91 23 83 47 61 86 79 49 46 1 18 73 38 40 33 1 57 5 39 24 50 13 93 20 86 20 81 24 42 69 38 20 33 68 35 67 49 19 38 79 13 32 89 10 41 29 33 30 6 31 52 60 0 21 81 42 66 29 62 13 34 5 18 81 6 63 37 0 99 99 57 62 16 79 51 0 55 78 79 45 96 54 44 34 75 47 96 83 13 32 25 9 47 96 66 31 63 19 28 85 87 96 17 67 24 27 39 64 24 96 13 90 60 42 24 63 98 11 69 47 75 25 68 9 56 30 60 36 91 33 6 18 17 12 36 92 32 75 41 29 3 83 1 49 86 80 60 38 4 48 76 34 58 1 91 81 87 66 78 10 47 63 37 56 69 64 68 26 4 19 7 64 38 18 46 46 0 99 7 32 90 88 90 24 17 50 19 4 2 94 99 23 93 56 93 67 47 80 88 25 97 39 95 28 63 34 84 89 84 51 38 45 16 81 25 49 93 87 48 50 75 40 79 73 20 92 11 90 42 87 60 37 47 12 50 58 7 27 31 46 18 80 40 95 83 48 31 21 32 45 26 32 32 85 26 98 94 76 99 46 0 87 4 34 80 13 99 57 18 85 0 77 5 47 98 45 37 8 71 49 86 74 88 34 70 49 33 44 27 3 81 6 95 26 16 17 11 23 67 50 5 72 33 71 25 83 56 89 35 71 60 95 50 89 63 95 61 11 98 86 15 65 4 22 57 89 9 4 41 64 90 41 70 47 0 26 63 21 66 51 32 67 97 0 44 54 74 4 9 49 67 47 75 46 12 52 16 47 50 52 96 34 59 93 93 48 60 55 26 39 99 12 94 37 35 21 16 69 22 68 66 89 59 29 27 91 83 29 93 82 14 74 83 28 39 2 44 29 80 42 75 83 63 40 68 73 7 44 92 91 63 52 92 0 10 75 5 19 3 24 8 0 99 52 15 91 22 13 82 46 43 83 5 4 88 62 81 99 46 74 97 23 9 55 58 53 60 9 88 14 77 18 37 86 41 43 15 38 31 2 99 37 38 15 32 79 32 14 67 14 86 80 33 62 83 50 26 34 50 54 29 53 40 62 80 48 90 4 88 29 31 20 42 28 42 88 81 42 32 9 36 75 49 24 71 26 2 88 2 13 58 72 74 71 65 70 85 33 7 49 73 20 78 0 49 8 8 23 83 95 39 71 50 90 26 8 48 17 33 98 4 23 62 86 79 8 56 86 36 66 49 8 2 31 71 65 30 33 11 65 71 90 66 75 27 99 93 34 23 51 25 48 74 40 69 76 99 92 76 91 29 76 31 39 8 15 19 72 86 79 67 60 32 73 81 86 64 21 11 44 0 82 78 21 57 67 91 98 10 52 50 73 83 60 84 56 26 59 29 72 77 81 16 98 62 22 75 67 25 34 18 76 8 88 43 85 57 46 76 40 60 23 26 91 84 45 35 14 41 92 19 94 3 33 70 61 82 80 13 11 50 20 28 36 91 96 77 17 62 87 44 94 82 29 43 13 54 26 29 88 92 17 10 69 56 61 73 99 99 36 19 33 43 95 8 59 7 82 56 21 12 47 68 64 36 59 2 48 6 90 75 88 63 90 37 86 72 6 86 6 22 0 28 82 55 17 74 56 42 95 7 44 79 34 10 90 93 12 63 68 89 46 46 1 83 47 98 44 75 43 12 16 90 38 33 26 28 97 70 25 32 74 56 91 19 27 20 60 61 92 93 68 45 14 24 14 67 12 46 20 41 54 22 19 96 85 14 91 9 66 88 89 40 67 64 45 15 11 21 42 65 87 13 1 27 33 39 77 0 46 1 5 73 17 18 33 15 66 74 84 29 45 4 44 50 11 10 74 49 6 9 44 48 70 27 30 23 81 22 49 85 96 86 36 97 37 20 97 99 64 46 67 17 93 87 45 75 12 8 52 11 8 92 99 74 92 50 44 72 44 97 18 19 71 90 61 55 13 74 62 4 87 86 16 66 52 72 86 62 68 94 8 43 41 15 85 32 17 35 58 24 27 33 12 80 77 0 31 37 7 13 82 44 23 37 24 22 72 67 34 20 23 38 45 7 52 24 11 5 78 26 33 58 45 24 95 19 24 9 50 41 57 42 20 76 1 36 55 62 70 72 49 4 83 42 45 68 26 61 33 70 25 70 0 49 52 72 82 69 36 17 44 96 72 40 68 66 92 91 24 10 54 19 51 50 26 26 72 14 7 97 4 46 9 76 80 75 58 44 63 40 43 55 58 38 40 63 38 81 16 1 28 50 72 92 92 99 91 7 35 49 7 52 86 18 47 88 20 74 96 99 73 36 31 61 22 7 57 31 2 14 42 35 34 46 7 8 12 34 79 1 37 13 1 58 64 81 65 97 29 27 2 28 88 76 59 44 12 11 30 68 71 80 72 24 26 81 9 21 99 36 0 36 23 18 55 75 47 43 1 44 11 30 8 0 60 72 83 11 83 46 36 54 55 48 0 46 30 69 40 57 81 88 88 15 45 84 15 52 89 53 54 64 68 31 5 64 30 93 64 76 16 31 67 58 77 53 94 78 99 40 16 7 34 46 51 59 94 14 62 64 12 34 5 43 99 38 2 13 76 30 25 84 6 60 79 15 9 83 80 51 24 88 3 3 22 83 87 0 14 42 67 14 50 90 92 74 54 95 23 6 95 63 38 30 42 19 15 89 59 99 32 51 55 43 99 54 33 6 98 37 90 6 44 32 49 34 50 20 38 66 40 98 67 25 56 67 15 6 5 32 95 24 57 43 88 58 33 62 56 84 67 59 50 92 83 33 59 78 99 47 42 87 88 27 96 60 93 43 22 75 19 24 57 30 12 31 80 26 9 5 77 36 15 21 1 18 5 14 78 28 4 68 94 93 29 69 6 22 32 81 47 39 2 13 58 34 88 94 14 5 95 49 37 78 92 49 80 29 62 21 61 23 92 30 0 94 41 34 86 54 30 90 72 90 77 92 24 88 77 60 7 64 63 12 60 31 96 32 90 81 9 60 55 56 71 31 5 24 13 43 42 61 24 86 8 24 6 55 24 86 99 51 55 62 88 77 71 86 7 1 43 34 64 53 78 1 65 88 99 73 0 49 79 41 7 88 9 97 87 64 42 19 15 61 17 33 35 49 0 40 75 46 5 36 33 14 37 61 11 8 42 47 52 15 18 61 59 9 71 13 97 90 82 24 88 75 61 40 64 2 92 72 10 72 18 35 49 58 71 33 56 81 13 23 39 57 21 70 14 41 91 20 36 97 69 11 94 4 28 10 2 94 12 11 67 90 98 98 7 34 86 40 24 84 53 69 50 7 45 31 30 43 13 21 3 70 81 20 89 9 6 29 15 91 86 19 3 89 22 27 49 32 73 23 92 68 82 65 9 53 83 29 22 24 24 42 72 27 83 45 50 6 26 59 73 79 56 47 8 9 49 92 85 81 12 13 7 50 91 87 87 76 21 95 18 40 69 77 17 34 88 65 40 43 36 34 17 93 48 24 28 34 68 31 28 10 55 3 93 78 24 90 98 62 1 9 31 62 15 80 19 85 58 61 47 79 26 52 86 1 84 36 58 35 62 46 26 34 10 51 94 7 78 64 36 1 1 28 40 31 51 37 81 58 58 11 36 58 25 18 82 36 34 47 3 49 52 58 66 97 93 40 39 70 96 20 90 20 3 19 97 74 60 29 73 20 29 75 42 6 24 80 87 80 64 28 38 83 14 95 74 95 12 15 3 19 75 17 15 99 50 51 82 5 91 96 81 12 17 32 57 17 52 54 86 75 89 23 79 14 63 57 68 72 71 18 46 89 67 16 29 18 17 63 52 38 19 62 94 40 84 78 21 59 40 0 39 56 0 29 94 38 71 4 25 17 58 65 1 81 3 70 38 46 46 99 26 41 25 31 96 30 56 81 7 26 26 93 46 55 23 93 88 70 56 16 8 93 53 11 63 55 0 29 71 53 28 36 56 51 80 95 27 8 19 78 46 48 46 31 22 76 77 64 8 27 27 93 31 51 72 16 8 54 45 62 84 65 50 45 55 20 53 97 22 36 92 89 14 61 41 97 64 39 69 48 46 57 38 63 8 69 75 88 12 83 10 25 64 49 54 31 94 32 12 19 14 13 50 21 51 75 26 10 80 4 57 44 98 39 81 33 80 50 62 81 64 14 49 34 65 77 39 81 13 90 7 80 51 43 31 46 42 4 74 75 94 52 32 70 65 86 71 1 75 43 37 72 71 54 19 9 73 33 89 52 0 95 45 87 93 31 38 9 74 96 81 21 34 46 62 6 38 66 53 57 93 30 65 99 89 44 43 57 37 1 92 18 80 30 40 21 67 11 14 13 68 81 26 38 43 22 71 52 85 38 74 94 37 97 20 13 43 8 34 36 97 34 91 98 32 28 61 67 94 29 33 90 78 4 25 71 10 76 79 49 99 95 91 20 64 94 67 99 27 29 71 93 84 46 56 53 56 9 11 11 47 60 50 41 18 84 75 24 27 4 69 37 3 13 47 64 66 51 54 20 96 92 32 47 47 27 58 57 20 53 90 10 51 55 69 66 52 19 96 5 30 34 19 2 37 27 11 88 91 39 42 60 35 9 29 47 58 32 61 90 61 75 47 16 33 53 78 7 18 42 7 18 50 55 0 31 33 6 11 52 86 46 9 8 70 79 55 14 65 65 49 55 14 59 74 72 19 99 33 94 14 45 45 98 56 89 12 93 56 98 26 74 89 93 29 40 55 99 25 58 80 94 98 20 48 27 18 8 63 42 38 95 59 47 89 99 12 18 20 30 25 26 4 49 70 66 36 18 97 80 84 44 10 44 64 30 61 61 48 15 79 31 92 21 33 81 60 99 62 1 26 74 77 15 10 5 42 87 47 69 73 31 4 76 12 41 68 36 71 38 3 24 11 81 53 72 21 14 25 44 38 34 99 27 30 60 88 29 20 99 87 22 69 4 4 10 50 7 4 63 77 41 20 1 17 71 77 17 6 56 33 92 3 14 87 76 66 15 57 26 94 38 11 55 12 79 8 69 32 85 85 77 80 47 54 56 51 79 82 43 8 84 59 92 54 43 98 82 96 97 21 97 46 32 34 75 86 91 86 19 38 95 75 61 91 84 82 11 50 5 89 83 11 17 20 16 11 39 36 15 92 57 65 96 81 29 58 47 28 93 95 87 79 25 46 64 66 15 92 40 62 95 10 36 56 49 99 81 82 20 30 23 71 37 53 8 71 89 5 54 13 80 97 16 60 59 75 25 53 1 11 20 51 90 61 50 54 85 61 64 90 72 14 17 24 70 76 17 39 25 45 13 69 85 20 36 57 38 64 81 17 34 23 79 72 27 86 50 34 88 50 28 48 66 49 37 63 27 7 83 70 52 33 67 84 40 11 41 1 1 14 14 5 89 5 41 22 77 89 71 94 71 33 64 84 15 40 92 57 22 81 54 61 30 44 84 95 53 23 20 98 55 6 75 1 59 81 98 45 20 47 9 36 62 2 0 6 1 93 93 29 44 55 54 77 15 64 81 97 7 75 97 66 54 34 17 45 72 70 77 65 8 14 49 71 5 90 3 46 54 33 84 47 80 84 47 37 67 72 5 18 82 48 36 46 21 7 19 98 99 16 44 86 81 15 31 0 31 57 63 63 32 53 70 91 20 29 12 76 94 88 1 91 80 1 85 62 97 2 58 95 85 64 90 71 56 30 90 5 76 38 38 90 1 7 34 46 13 82 35 81 21 12 8 95 87 35 48 49 88 81 85 48 10 54 18 65 15 60 66 24 70 78 25 83 40 73 37 15 38 14 18 33 94 19 22 54 88 66 97 49 20 54 92 82 57 69 65 16 92 43 64 49 43 56 1 78 17 21 98 78 28 5 66 48 91 7 28 88 58 89 55 60 12 63 80 64 27 10 0 92 22 57 27 74 4 93 24 35 49 17 17 8 31 88 24 33 99 43 37 42 18 72 76 3 47 66 28 70 51 60 73 32 13 52 87 5 92 36 19 93 14 95 27 91 47 74 90 34 10 15 58 43 64 80 35 1 63 38 1 52 71 80 5 61 89 34 61 53 12 78 26 69 46 33 92 49 11 92 69 65 17 31 10 55 51 21 31 32 40 14 10 83 33 49 52 68 27 33 4 19 68 38 9 59 52 38 70 58 59 66 33 19 62 27 41 11 72 34 89 58 56 12 31 6 61 76 78 62 29 59 61 97 87 69 3 46 88 93 88 32 37 47 21 95 87 15 64 78 15 99 77 20 45 35 5 57 76 28 38 94 1 50 39 5 26 58 18 40 26 40 23 53 35 40 71 91 87 48 51 12 31 78 67 98 73 18 36 49 98 94 86 42 98 52 2 22 53 82 60 87 78 82 5 13 21 36 50 29 57 68 68 37 89 32 75 19 62 99 58 33 15 94 37 27 28 55 11 21 19 45 35 24 84 79 61 34 1 32 41 66 24 32 1 78 69 35 33 97 27 13 77 49 42 19 82 89 91 97 77 93 1 5 65 75 53 14 32 30 25 7 86 42 17 56 14 10 50 91 41 14 24 48 21 29 80 61 7 28 51 77 57 26 79 53 20 7 84 25 9 88 21 2 23 88 29 48 6 93 97 7 11 91 10 52 81 34 80 21 70 28 9 39 14 84 44 31 74 30 93 55 53 24 79 84 73 42 89 53 69 60 38 72 70 92 95 96 17 75 85".Split(' ');
            var values = Array.ConvertAll(split, int.Parse);

/*
INPUT:
7
0 1 2 4 6 5 3
OUTPUT: 3

15
5 5 3 3 1 4 2 7 7 5 5 3 3 1 1
3

15
1 1 1 2 3 3 3 3 4 4 4 4 5 5 5 5 7
4
*/
            // Partition Until left & right size is NOT the SAME.
            int pivotIndex = 0;
            var partition = Partition(values, pivotIndex++);
            var newValues = ConvertPartitionToArray(partition);
            var tempMedian = newValues[newValues.Length / 2];

            //while (partition.Item1.Count != partition.Item3.Count && partition.Item2 != tempMedian)
            while (true)
            {
                //if (partition.Item1.Count == partition.Item3.Count || partition.Item2 == tempMedian)
                //{
                //    Console.WriteLine(partition.Item2);
                //    return;
                //}

                partition = Partition(values, pivotIndex++);
                newValues = ConvertPartitionToArray(partition);
                tempMedian = newValues[newValues.Length / 2];
            }
        }

        private static int[] ConvertPartitionToArray(Tuple<List<int>, int, List<int>> partition)
        {
            const int pivotSize = 1;
            var newSize = partition.Item1.Count + pivotSize + partition.Item3.Count;

            List<int> result = new List<int>(newSize);
            result.AddRange(partition.Item1);
            result.Add(partition.Item2);
            result.AddRange(partition.Item3);

            return result.ToArray();
        }

        private static Tuple<List<int>, int, List<int>> Partition(int[] a, int pivotIndex)
        {
            int partitionSize = a.Length / 2;
            var left = new List<int>(partitionSize);
            var pivot = a[pivotIndex];
            var right = new List<int>(partitionSize);

            for (int i = 0; i < a.Length; i++)
            {
                if (i == pivotIndex) continue;

                int value = a[i];

                if (value < pivot)
                    left.Add(value);

                if (value > pivot)
                    right.Add(value);

                if (value == pivot)
                    right.Add(value);
            }

            return Tuple.Create(left, pivot, right);
        }
    }
}
