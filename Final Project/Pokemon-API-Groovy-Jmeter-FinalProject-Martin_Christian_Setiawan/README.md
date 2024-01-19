# PokeAPI JMeter Test

## Task 1 : Find the Next Evolution of Pikachu

1. Create a new test plan
2. Add new **_Thread Group_**
3. Add new **_HTTP Server Defaults_**
   ![img_1.png](https://github.com/kurisu-snek/CIMB_Specialization/blob/main/Final%20Project/Pokemon-API-Groovy-Jmeter-FinalProject-Martin_Christian_Setiawan/Screenshot/Capture_1_Set_default_server.PNG)
4. Set user variables
   ![img_2.png](https://github.com/kurisu-snek/CIMB_Specialization/blob/main/Final%20Project/Pokemon-API-Groovy-Jmeter-FinalProject-Martin_Christian_Setiawan/Screenshot/Capture_2_Set_User_Variables.PNG)

**Perform a looped HTTP GET request to the Pokémon API to search for Pikachu's species information. Start with an offset of 0 and limit the results to 20 per request.**

1. Add new Transaction Controller
2. Add new **_While Controller_**
   ![img_3.png](https://github.com/kurisu-snek/CIMB_Specialization/blob/main/Final%20Project/Pokemon-API-Groovy-Jmeter-FinalProject-Martin_Christian_Setiawan/Screenshot/Capture_3_While_Controller.PNG)
3. Create a counter set starting value 0 and increment 20 and store it to a variable named **_"offset"_** under HTTP Request
   ![img_4.png](https://github.com/kurisu-snek/CIMB_Specialization/blob/main/Final%20Project/Pokemon-API-Groovy-Jmeter-FinalProject-Martin_Christian_Setiawan/Screenshot/Capture_5_Offest_Counter.PNG)

### Endpoint

Target Endpoint: https://pokeapi.co/api/v2/pokemon-species?offset=0&limit=20

![img_5.png](https://github.com/kurisu-snek/CIMB_Specialization/blob/main/Final%20Project/Pokemon-API-Groovy-Jmeter-FinalProject-Martin_Christian_Setiawan/Screenshot/Capture_4_HTTP_Request.PNG)

1. Create HTTP Request to the endpoint
   - Endpoint path is set as `${pathEndPoint}/pokemon-species` as `${pathEndPoint}` is set from User Variables
2. Extract the data needed, for this case extract the JSON response with JSON Extractor by add path expression `$.results[?(@.name == 'pikachu')]`
3. Set the **_"isPokemonFound"_** variable to **"true"** so the while looping will be stopped
4. log the details of the Pokémon
   ![img_6.png](https://github.com/kurisu-snek/CIMB_Specialization/blob/main/Final%20Project/Pokemon-API-Groovy-Jmeter-FinalProject-Martin_Christian_Setiawan/Screenshot/Capture_6_Log_Details.PNG)

## Task 2 : Find All Pokémon with Wings

<ol type="a">
 <li>
   Retrieve All Pokémon Shapes :
   <ol type="1">
      <li>Create new transaction controller</li> 
      <li>Create HTTP Request to <a>${pathEndPoint}/pokemon-shape</a> (Path targets <a>https://pokeapi.co/api/v2/pokemon-shape</a>)</li>
      <li>Extract JSON Response that contains the results list of pokemon-shape</li>
      <li>Log the extracted result</li>
   </ol>
 </li>
 <li>
   Identify the 'Wings' Shape : 
   <ol type="1">
      <li>Log the wings id and url</li>
   </ol>
 </li>
 <li>
   Retrieve All Pokémon with the 'Wings' Shape : 
   <ol type="1">
      <li>Create HTTP Request to the 'Wings' shape url that already extracted</li>
      <l1>Extract the JSON Response to get the Pokémon name list with 'Wings' shape</l1>
      <li>Log the extracted result</li>
      <img src="https://github.com/kurisu-snek/CIMB_Specialization/blob/main/Final%20Project/Pokemon-API-Groovy-Jmeter-FinalProject-Martin_Christian_Setiawan/Screenshot/Capture_7_Wing_Log_Details.PNG">
   </ol>
 </li>
</ol>
