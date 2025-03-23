<?php
    $db = mysqli_connect("127.0.0.1", "root", "root", "ingatlan");
    switch($_SERVER["REQUEST_METHOD"]){
        case "GET":{
            $res = mysqli_fetch_all(mysqli_query($db, "CALL getAll();"), MYSQLI_ASSOC);
            echo json_encode($res);
            http_response_code(200);
            break;
        }
        case "POST":{
            $in = json_decode(file_get_contents("php://input"), true);
            try{
                $res = mysqli_fetch_all(mysqli_query($db,
                    sprintf('CALL createIngatlan(%s, "%s", "%s", %s, %s, "%s");', $in["kategoria"], $in["leiras"], $in["hirdetesDatuma"], $in["tehermentes"], $in["ar"], $in["kepUrl"])
                ), MYSQLI_ASSOC);
            }
            catch(Exception $ex){
                $res = ["id"=>-1];
            }

            if($res[0]["id"] != -1){
                echo json_encode($res[0]);
                http_response_code(201);
            }
            else{
                echo "Hiányos adatok";
                http_response_code(400);
            }
            break;
        }
        case "DELETE":{
            $in = explode("/", $_SERVER["REQUEST_URI"]);
            $res = mysqli_fetch_all(mysqli_query($db,
                sprintf('CALL deleteIngatlan(%s);', $in[count($in)-1])
            ), MYSQLI_ASSOC);
            
            if($res[0]["ok"] == 1){
                http_response_code(204);
            }
            else{
                echo "Az ingatlan nem létezik";
                http_response_code(400);
            }
        }
    }
?>