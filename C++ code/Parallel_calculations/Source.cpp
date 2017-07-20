#include <bits\stdc++.h>
#include<omp.h>
using namespace std;

extern "C" __declspec(dllexport) void solve(double(&data)[480][944], double(&tmp)[480][944], int normal[480][944], int block[480][944], int r, int c, int threads_Number) {
	omp_set_num_threads(threads_Number);

#pragma omp parallel
	{
#pragma omp for 
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				int valid_cells_number = 1;

				if (normal[i][j] == false)
				{
					continue;
				}

				if (i + 1 < r && i + 1 > -1 && j + 1 < c && j + 1 > -1 && block[i + 1][j + 1] == false)
				{
					data[i][j] += tmp[i + 1][j + 1];
					valid_cells_number++;
				}

				if (i + 1 < r && i + 1 > -1 && j - 1 < c && j - 1 > -1 && block[i + 1][j - 1] == false)
				{
					data[i][j] += tmp[i + 1][j - 1];
					valid_cells_number++;
				}

				if (i + 1 < r && i + 1 > -1 && j < c && j > -1 && block[i + 1][j] == false)
				{
					data[i][j] += tmp[i + 1][j];
					valid_cells_number++;
				}

				if (i - 1 < r && i - 1 > -1 && j + 1 < c && j + 1 > -1 && block[i - 1][j + 1] == false)
				{
					data[i][j] += tmp[i - 1][j + 1];
					valid_cells_number++;
				}

				if (i - 1 < r && i - 1 > -1 && j - 1 < c && j - 1 > -1 && block[i - 1][j - 1] == false)
				{
					data[i][j] += tmp[i - 1][j - 1];
					valid_cells_number++;
				}

				if (i - 1 < r && i - 1 > -1 && j < c && j > -1 && block[i - 1][j] == false)
				{
					data[i][j] += tmp[i - 1][j];
					valid_cells_number++;
				}

				if (i <r && i > -1 && j + 1 < c && j + 1 > -1 && block[i][j + 1] == false)
				{
					data[i][j] += tmp[i][j + 1];
					valid_cells_number++;
				}

				if (i <r && i > -1 && j - 1 < c && j - 1 > -1 && block[i][j - 1] == false)
				{
					data[i][j] += tmp[i][j - 1];
					valid_cells_number++;
				}
				data[i][j] /= (double)valid_cells_number;
			}
		}
	}
	//==============================================
#pragma omp parallel
	{
#pragma omp for
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				tmp[i][j] = data[i][j];
			}
		}
	}
}

int main() {



}