package com.company;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;

public class Server1 {

    public static void main(String[] args)throws  Exception {
        String req;
        String res;
        ServerSocket welcomeSocket = new ServerSocket(6780);
        while (true) {
            System.out.println("Wait for a client");
            Socket connectionSocket = welcomeSocket.accept();
            System.out.println("Client has connected");
            BufferedReader inFromClient = new BufferedReader(new InputStreamReader(connectionSocket.getInputStream()));
            DataOutputStream outToClient = new DataOutputStream(connectionSocket.getOutputStream());
            req = inFromClient.readLine();
            System.out.println("Filename has been received");
            String filename = "F:\\учеба\\5 семестр\\ИС\\лр3\\Server1\\Files\\" + req;
            File f = new File(filename);
            if (f.exists()) {
                res = "File has been find" + "\n";
                outToClient.writeBytes(res);
                int r = 0;
                FileInputStream fromFile1 = new FileInputStream(filename);
                while (r != -1) {
                    r = fromFile1.read();
                    outToClient.writeUTF(r + "");
                }
            } else {
                res = "Not find" + "\n";
                outToClient.writeBytes(res);
            }
            System.out.println("Information has been sent");
        }
    }
}
