package com.company;

import java.io.*;
import java.net.Socket;

public class CallService {
    public String ask(String filename) throws  Exception{
        String path = "F:\\учеба\\5 семестр\\ИС\\лр3\\Server\\Files\\downloadedFile";
        BufferedReader inFromUser = new BufferedReader( new InputStreamReader(System.in));
        Socket clientSocket = new Socket ("127.0.0.2", 6780);
        DataOutputStream outToServer = new DataOutputStream(clientSocket.getOutputStream());
        BufferedReader inFromServer = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
        outToServer.writeBytes(filename + "\n");
        String answer = inFromServer.readLine();
        if (!answer.equals("Not find")){
            String r1 = new String();
            int r=0;
            FileOutputStream toFile1 = new FileOutputStream(path);
            BufferedOutputStream toFile= new BufferedOutputStream(toFile1);
            DataInputStream recv = new DataInputStream(clientSocket.getInputStream());
            while(r!=-1) {
                r1 = recv.readUTF();
                r = Integer.parseInt(r1);
                toFile.write(r);
            }
            clientSocket.close();
            return answer;
        }
        else {
            clientSocket.close();
            return answer;
        }
    }
}
