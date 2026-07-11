public class Solution {
    public bool Exist(char[][] board, string word) {
        
        var rows= board.Length;
        var cols = board[0].Length;
        

        for(var i =0;i<rows;i++){
            for(var j=0;j<cols;j++){
                if(wordsearch(board,word,i,j,0))
                {
                    return true;
                }

            }
        }
         return false;


    }

    public bool wordsearch(char[][]board,string word,int r,int c, int index){
        if(index==word.Length){
            return true;
        }
        if(r<0 || r>=board.Length || c<0 || c>=board[0].Length || board[r][c]!=word[index]){
            return false;
        }
        var temp = board[r][c];
        board[r][c]='#';
       bool res=wordsearch(board,word,r+1,c,index+1) || wordsearch(board,word,r-1,c,index+1) || wordsearch(board,word,r,c+1,index+1)||wordsearch(board,word,r,c-1,index+1);
         board[r][c]=temp;
         return res;
    }
}
