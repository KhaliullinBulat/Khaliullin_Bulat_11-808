class Encoder
    def initialize (number)
	@dwCaseAlph = ('a'..'z').to_a
	@upCaseAlph = ('A'..'Z').to_a
	@fixedText = ""
	@num = number
    end

    def encode (wayToFixingDoc, wayToGettingDoc)
        File.open(wayToFixingDoc, "r") do |file|
            for line in file.readlines()  
                for index in 0..line.length() - 1
	            if @dwCaseAlph.include?(line[index])
			if @dwCaseAlph.index(line[index]) + @num >= @dwCaseAlph.length()
			    newIndex = (@dwCaseAlph.index(line[index]) + @num) % @dwCaseAlph.length()
			else
	    	            newIndex = @dwCaseAlph.index(line[index]) + @num
			end
	       	        @fixedText += @dwCaseAlph[newIndex]
	            elsif @upCaseAlph.include?(line[index])
			if @upCaseAlph.index(line[index]) + @num >= @upCaseAlph.length()
			    newIndex = (@upCaseAlph.index(line[index]) + @num) % @upCaseAlph.length()
			else
	    	            newIndex = @upCaseAlph.index(line[index]) + @num
			end
		        @fixedText += @upCaseAlph[newIndex]
	            else
		        @fixedText += line[index]
	            end
                end
            end
        end

        File.open(wayToGettingDoc, "a") do |file|
            file.write(@fixedText + "\n")
	    @fixedText =""
        end
    end

    def decode (wayToFixingDoc, wayToGettingDoc)
        File.open(wayToFixingDoc, "r") do |file|
            for line in file.readlines()  
                for index in 0..line.length() - 1
	            if @dwCaseAlph.include?(line[index])
			if 0 > @dwCaseAlph.index(line[index]) - @num
			    newIndex = @dwCaseAlph.length() + @dwCaseAlph.index(line[index]) - @num
			else
	    	            newIndex = @dwCaseAlph.index(line[index]) - @num
			end
	       	        @fixedText += @dwCaseAlph[newIndex]
	            elsif @upCaseAlph.include?(line[index])
			if 0 > @upCaseAlph.index(line[index]) - @num
			    newIndex = @upCaseAlph.length() + @upCaseAlph.index(line[index]) - @num
			else
	    	            newIndex = @upCaseAlph.index(line[index]) - @num
			end
	       	        @fixedText += @upCaseAlph[newIndex]
	            else
		        @fixedText += line[index]
	            end
                end
            end
        end

        File.open(wayToGettingDoc, "a") do |file|
            file.write(@fixedText + "\n")
	    @fixedText = ""
        end
    end
end

class Program
    def Main
	puts("Enter a number between 1 and 27: ")
	number = gets.to_i
	puts("Enter a way to document which you want to encode: ")
	wayToEncode = gets
	puts("Enter a way to document in which you want to keep an encoded text: ")
	wayToEncoded = gets
	puts("Enter a way to document which you want to decode: ")
	wayToDecode = gets
	puts("Enter a way to document in which you want to keep a decoded text: ")
	wayToDecoded = gets
	encoder = Encoder.new(number)
	encoder.encode(wayToEncode, wayToEncoded)
	encoder.decode(wayToDecode, wayToDecoded)
    end
end
