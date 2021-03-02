package com.company;

import javax.swing.*;
import  java.io.*;
import  java.net.*;

public class Server {

    public static void main(String[] args) throws  Exception {
        String req;
        String res;
        ServerSocket welcomeSocket = new ServerSocket(6789);
        while (true) {
            System.out.println("Wait for a client");
            Socket connectionSocket = welcomeSocket.accept();
            Thread t = new Thread((new Startthread(connectionSocket)));
            t.start();
        }
    }
}
