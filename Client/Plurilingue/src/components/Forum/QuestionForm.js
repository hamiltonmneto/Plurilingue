//import liraries
import React, { Component, TouchableOpacity } from 'react';
import { StyleSheet, Dimensions, FlatList } from 'react-native';
import { Container, Content, List, ListItem, Text, Left, Body, Right, Textarea, Button } from 'native-base';
import Icon from 'react-native-vector-icons/Ionicons';
import axios from 'axios';

// create a component
const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
class QuestionForm extends Component {
    constructor(){
        super();
        this.state={
            question: [],
            AnswerContent: '',
            isAuthor: false,
            isResponder: false
        }
    }

    bestAnswerPressed(id){
        axios({
            url: `https://plurilingueapplication20190526092258.azurewebsites.net/v1/Forum/BestAnswer/${id}`,
            method: 'post',
            data: {
                id: id,
            },
            headers: {
              Accept: 'application/json',
              'Content-Type': 'application/json',
            }
          })
          .then(response => {
            this.props.navigation.navigate('Forum');
          })
          .catch(error => {
            console.warn("DEU ERRO");
            // this.props.navigation.navigate('Erro', {errorMessage: error.response.data, screenPath: this.props.navigation.state.routeName});
          });
    }

    submit(){

        axios({
            url: 'https://plurilingueapplication20190526092258.azurewebsites.net/v1/Forum/RegisterAnswer',
            method: 'post',
            data: {
                Question_Id: this.state.question.id,
                AnswerContent: this.state.AnswerContent
            },
            headers: {
              Accept: 'application/json',
              'Content-Type': 'application/json',
            }
          })
          .then(response => {
            this.props.navigation.navigate('Forum');
          })
          .catch(error => {
            console.warn("DEU ERRO");
          });
      
      }
    
    render() {
        const { navigation } = this.props;
        const User_id = navigation.getParam('userId');
        this.state.question = navigation.getParam('question');
        if(User_id == this.state.question.user.id)
          this.state.isAuthor = true

        return (
            <Container>
            <Content>
                <List>
                    <ListItem avatar style={styles.questionContent}>
                        <Body>
                            <Text style={styles.title}>{this.state.question.title}</Text>
                            <Text note numberOfLines={1} style={styles.textContent}>{this.state.question.textContent}</Text>
                        </Body>
                    </ListItem>
                    <FlatList
                    data={this.state.question.answers}
                    renderItem={({item}) => (
                        <ListItem avatar style={styles.answerContent}>
                            <Left style={{margin: 20}}>
                                {item.isBestAnswer ? (<Icon name='ios-checkbox' size={50} color={'#03e469'}></Icon>) : 
                                    this.state.isAuthor ? (<Icon name='ios-checkbox-outline' size={50} onPress={() => this.bestAnswerPressed(item.id)}/>) : null}
                            </Left>
                            <Body>
                                <Text>{item.textContent}</Text>
                            </Body>
                        </ListItem>
                    )} 
                    keyExtractor={(item, index) => index.toString()}
                    />
                </List>
                {this.state.isAuthor ? null :
                    <Content>
                        <Textarea rowSpan={5} bordered placeholder='Your answer goes here' 
                            style={{marginTop: 30, width: WIDTH - 60, left: 30}}
                            onChangeText={value=> this.setState({ AnswerContent: value})}
                            value={this.state.AnswerContent}/>
                        <Button block danger style={{width: WIDTH - 100, marginTop: 40, marginBottom: 40, justifyContent: 'center', left: 50}} onPress={() => this.submit()}>
                                <Text style={{fontSize: 18, color: 'white', fontWeight: 'bold'}}>Submit</Text>
                        </Button>
                    </Content>
                }
            </Content>
          </Container>
        );
    }
}

// define your styles
const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#fff',
    },
    title:{
        marginTop: 10,
        marginBottom: 10,
        fontSize: 24,
        fontWeight: 'bold'
    },
    questionContent:{
        backgroundColor: '#dedede',
        width: WIDTH - 40,
        borderRadius: 10,       
    },
    textContent:{
        fontSize: 18,
    },
    answerContent:{
        backgroundColor: '#f1efef',
        width: WIDTH - 40,
        borderRadius: 10,  
    }
});

//make this component available to the app
export default QuestionForm;
