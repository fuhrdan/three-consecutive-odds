//*****************************************************************************
//** 1550. Three Consecutive Odds leetcode                                   **
//** Simple Loop with modulo to solve -Dan                                   **
//*****************************************************************************

bool threeConsecutiveOdds(int* arr, int arrSize) {
    for (int i = 0; i < arrSize-2; i++)
    {
        if((arr[i] % 2 == 1)&&(arr[i+1]%2==1)&&(arr[i+2]%2==1)) { return true;}
//                printf("arr[%d] = %d, arr[%d] = %d, arr[%d] = %d\n",i,arr[i],i+1,arr[i+1],i+2,arr[i+2]);
    }
    return false;
}