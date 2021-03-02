package com.company;

import  java.io.*;
import  java.net.*;

public class Client {

    public static void main(String[] args) throws  Exception{
        String path = "F:\\учеба\\5 семестр\\ИС\\лр3\\Client\\Files\\downloadedFile";
        String req;
        String res;
        BufferedReader inFromUser = new BufferedReader( new InputStreamReader(System.in));
        Socket clientSocket = new Socket ("127.0.0.1", 6789);
        DataOutputStream outToServer = new DataOutputStream(clientSocket.getOutputStream());
        BufferedReader inFromServer = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
        req = inFromUser.readLine();
        outToServer.writeBytes(req + "\n");
        res = inFromServer.readLine();
        System.out.println("FROM SERVER:"  + res);
        if (!res.equals("Not find")){
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
            System.out.println("File has been downloaded");
        }
        else
            clientSocket.close();
    }
}
